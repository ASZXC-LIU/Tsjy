using System.Text;

using System.Net.Mime;
using SystemIO = System.IO;
using Docnet.Core;
using Docnet.Core.Models;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Formats.Png;
using Tesseract;

using PigPdfDocument = UglyToad.PdfPig.PdfDocument;
using PigPage = UglyToad.PdfPig.Content.Page;

namespace Tsjy.Application.System.Service.AI;

public sealed class PdfExtractOptions
{
    public long MaxPdfBytes { get; set; } = 10 * 1024 * 1024;

    // 文本提取结果太短就判定为“可能是扫描件”，走 OCR
    public int MinTextCharsToSkipOcr { get; set; } = 200;

    // OCR 最多识别多少页（避免太慢）
    public int MaxOcrPages { get; set; } = 3;

    // OCR 渲染 DPI（越高越清晰越慢）
    public int OcrDpi { get; set; } = 200;

    // 每个 PDF 最多塞多少字符到 prompt
    public int MaxCharsPerPdf { get; set; } = 12000;

    // 总共最多塞多少字符（多个 PDF 加起来）
    public int MaxCharsTotal { get; set; } = 40000;

    // tessdata 路径（输出目录下的相对路径）
    public string TessdataPath { get; set; } = "Resources/tessdata";

    // 语言：简中+英文
    public string OcrLang { get; set; } = "chi_sim+eng";
}

public static class PdfTextExtractor
{
    public static async Task<string> ExtractEvidenceTextAsync(
        IReadOnlyList<string> pdfPaths,
        PdfExtractOptions opt,
        CancellationToken ct = default)
    {
        if (pdfPaths == null || pdfPaths.Count == 0) return "（未提供PDF佐证材料）";

        var sb = new StringBuilder();
        var total = 0;

        foreach (var path in pdfPaths)
        {
            ct.ThrowIfCancellationRequested();

            if (!SystemIO.File.Exists(path)) continue;
            var fi = new SystemIO.FileInfo(path);
            if (fi.Length > opt.MaxPdfBytes)
            {
                sb.AppendLine($"文件过大已跳过（{fi.Length} bytes）");
                sb.AppendLine();
                continue;
            }

            string extracted = await ExtractSinglePdfAsync(path, opt, ct);

            // 截断单份
            if (extracted.Length > opt.MaxCharsPerPdf)
                extracted = extracted.Substring(0, opt.MaxCharsPerPdf) + "\n（已截断：该PDF内容过长）";

            // 控制总长度
            if (total + extracted.Length > opt.MaxCharsTotal)
            {
                var remain = Math.Max(0, opt.MaxCharsTotal - total);
                if (remain > 200)
                {
                    extracted = extracted.Substring(0, remain) + "\n（已截断：证据总长度达到上限）";
                    sb.AppendLine($"");

                    sb.AppendLine(extracted);
                }
                else
                {
                    sb.AppendLine("（已截断：证据总长度达到上限，后续PDF未继续加入）");
                }
                break;
            }

            sb.AppendLine($"");
            sb.AppendLine(extracted.Length == 0 ? "（未提取到文本：可能是扫描件/图片型PDF）" : extracted);
            sb.AppendLine();

            total += extracted.Length;
        }

        return sb.ToString();
    }

    private static Task<string> ExtractSinglePdfAsync(string pdfPath, PdfExtractOptions opt, CancellationToken ct)
    {
        // 这部分主要是 CPU 计算，不是真异步；包一层 Task.Run 防止阻塞请求线程
        return Task.Run(() =>
        {
            ct.ThrowIfCancellationRequested();

            // 1) 先尝试文本提取（文本型 PDF 最快）
            var text = ExtractTextByPdfPig(pdfPath);

            // 2) 文本太少 → OCR（扫描件）
            if (text.Trim().Length < opt.MinTextCharsToSkipOcr)
            {
                var ocr = ExtractTextByOcr(pdfPath, opt, ct);
                if (!string.IsNullOrWhiteSpace(ocr))
                    return ocr;
            }

            return text;

        }, ct);
    }

    private static string ExtractTextByPdfPig(string pdfPath)
    {
        try
        {
            var sb = new StringBuilder();

            using var doc = PigPdfDocument.Open(pdfPath);
            foreach (PigPage page in doc.GetPages())
            {
                var t = page.Text;
                if (!string.IsNullOrWhiteSpace(t))
                {
                    sb.AppendLine(t);
                    sb.AppendLine();
                }
            }

            return sb.ToString().Trim();
        }
        catch
        {
            return "";
        }
    }

    private static string ExtractTextByOcr(string pdfPath, PdfExtractOptions opt, CancellationToken ct)
    {
        try
        {
            var baseDir = AppContext.BaseDirectory;
            var tessdataAbs = SystemIO.Path.Combine(baseDir, opt.TessdataPath);

            using var engine = new TesseractEngine(tessdataAbs, opt.OcrLang, EngineMode.Default);
            engine.DefaultPageSegMode = PageSegMode.Auto;

            // 读 PDF bytes
            var pdfBytes = SystemIO.File.ReadAllBytes(pdfPath);

            // 给一个“足够清晰”的渲染尺寸（近似 A4 @ DPI）
            // A4: 8.27 x 11.69 inch
            var w = (int)(8.27 * opt.OcrDpi);
            var h = (int)(11.69 * opt.OcrDpi);

            using var docReader = DocLib.Instance.GetDocReader(pdfBytes, new PageDimensions(w, h));
            var take = Math.Min(docReader.GetPageCount(), opt.MaxOcrPages);

            var sb = new StringBuilder();

            for (int i = 0; i < take; i++)
            {
                ct.ThrowIfCancellationRequested();

                using var pageReader = docReader.GetPageReader(i);
                var width = pageReader.GetPageWidth();
                var height = pageReader.GetPageHeight();

                // Docnet 返回 BGRA 原始像素
                var raw = pageReader.GetImage(); // byte[] length = width*height*4

                // 用 ImageSharp 把 BGRA 像素编码成 PNG
                using var img = Image.LoadPixelData<Bgra32>(raw, width, height);
                using var ms = new SystemIO.MemoryStream();
                img.Save(ms, new PngEncoder());
                var pngBytes = ms.ToArray();

                // Tesseract 直接从 PNG bytes 识别
                using var pix = Pix.LoadFromMemory(pngBytes);
                using var ocrPage = engine.Process(pix);

                var txt = ocrPage.GetText();
                if (!string.IsNullOrWhiteSpace(txt))
                {
                    sb.AppendLine(txt.Trim());
                    sb.AppendLine();
                }
            }

            return sb.ToString().Trim();
        }
        catch
        {
            return "";
        }
    }
}
