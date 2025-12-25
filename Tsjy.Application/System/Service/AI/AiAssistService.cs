using System.Text;
using System.Text.Json;
using Furion.DependencyInjection;
using Google.GenAI;
using Google.GenAI.Types;
using Microsoft.Extensions.Options;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.AI;
using Tsjy.Application.System.Dtos.ReviewDtos;
using Tsjy.Application.System.IService;
using Tsjy.Application.System.Service;
using SystemIO = System.IO;

namespace Tsjy.Application.System.Service;

/// <summary>
/// 评审专家 AI 辅助服务：
/// - 读取指标信息（TaskService.GetNodeFillDetail）
/// - 读取该指标 PDF 文件（FileService 列目录 + 读本地文件）
/// - 上传到 Gemini Files API 并作为 FileData 输入，让模型直接“看 PDF”
/// </summary>
public sealed class AiAssistService : IAiAssistService, ITransient
{
    private readonly IOptions<GeminiOptions> _opt;
    private readonly TaskService _taskService;
    private readonly FileService _fileService;

    public AiAssistService(IOptions<GeminiOptions> opt, TaskService taskService, FileService fileService)
    {
        _opt = opt;
        _taskService = taskService;
        _fileService = fileService;
    }

    public async Task<AiAssistResultDto> ExpertAssistAsync(long taskId, long nodeId, CancellationToken ct = default)
    {
        var opt = _opt.Value;
        if (string.IsNullOrWhiteSpace(opt.ApiKey))
            throw new Exception("Gemini ApiKey 未配置（请在 appsettings / UserSecrets 配置 Gemini:ApiKey）");

        // 1) 指标信息
        NodeFillDetailDto detail = await _taskService.GetNodeFillDetail(taskId, nodeId);

        // 2) 本地 PDF（只取本指标目录）
        var urls = _fileService.GetEvidenceUrlList(taskId, nodeId);
        var physicalFiles = urls
            .Select(u => _fileService.TryResolvePhysicalPathFromUrl(u))
            .Where(p => !string.IsNullOrWhiteSpace(p) && SystemIO.File.Exists(p!))
            .Take(opt.MaxPdfFiles)
            .Cast<string>()
            .ToList();

        // 3) Gemini client
        var client = new Client(apiKey: opt.ApiKey); // Gemini Developer API :contentReference[oaicite:1]{index=1}

        // 4) 上传 PDF → 拿到 fileUri → 作为 FileData 输入
        var uploadedFileNames = new List<string>(); // 用于 finally 清理
        var pdfParts = new List<Part>();

        foreach (var path in physicalFiles)
        {
            var fileInfo = new SystemIO.FileInfo(path);
            if (fileInfo.Length > opt.MaxPdfBytes) continue;

            var bytes = await SystemIO.File.ReadAllBytesAsync(path, ct);

            // Files.UploadAsync(bytes, fileName) :contentReference[oaicite:2]{index=2}
            var upload = await client.Files.UploadAsync(bytes: bytes, fileName: SystemIO.Path.GetFileName(path));
            // upload 通常包含 Name/Uri 等字段；FileData 里用 Uri（示例中是 generativelanguage 的 files URL） :contentReference[oaicite:3]{index=3}
            var fileUri = upload.Uri ?? upload.Name; // 双保险：有的返回 Uri，有的只给 name

            if (string.IsNullOrWhiteSpace(fileUri)) continue;

            uploadedFileNames.Add(upload.Name);

            pdfParts.Add(new Part
            {
                FileData = new FileData
                {
                    FileUri = fileUri,
                    MimeType = "application/pdf"
                }
            });
        }

        // 5) 组织 Prompt（严格要求 JSON 输出）
        var prompt = BuildPrompt(detail);

        var contents = new List<Content>
        {
            new Content
            {
                Role = "user",
                Parts = new List<Part> { new Part { Text = prompt } }
            }
        };

        // 把 PDF part 追加到同一个 user content
        contents[0].Parts.AddRange(pdfParts);

        var config = new GenerateContentConfig
        {
            Temperature = opt.Temperature,
            MaxOutputTokens = opt.MaxOutputTokens,
            ResponseMimeType = "application/json",
        };

        try
        {
            var resp = await client.Models.GenerateContentAsync(
                model: opt.Model,
                contents: contents,
                config: config
            );

            var text = resp?.Candidates?.FirstOrDefault()?.Content?.Parts?.FirstOrDefault()?.Text ?? "";
            if (string.IsNullOrWhiteSpace(text))
                throw new Exception("AI 未返回内容（可能被安全策略拦截或输出为空）");

            return ParseAiJson(text, detail);
        }
        finally
        {
            // 尽量清理上传到 Gemini Files API 的临时文件（防止越积越多）
            foreach (var name in uploadedFileNames.Where(n => !string.IsNullOrWhiteSpace(n)))
            {
                try
                {
                    await client.Files.DeleteAsync(name: name); // DeleteAsync 示例 :contentReference[oaicite:4]{index=4}
                }
                catch
                {
                    // 清理失败不影响主流程
                }
            }
        }
    }

    private static string BuildPrompt(NodeFillDetailDto d)
    {
        var sb = new StringBuilder();

        sb.AppendLine("你是中国教育评价体系的评审专家。你将基于“评分标准”和“PDF佐证材料内容”给出建议评分。");
        sb.AppendLine("必须遵守：只依据提供的信息，不允许臆测；若材料缺失要明确指出缺失项。");
        sb.AppendLine();
        sb.AppendLine("【指标信息】");
        sb.AppendLine($"- 一级指标：{d.FirstIndicator}");
        sb.AppendLine($"- 二级指标：{d.SecondIndicator}");
        sb.AppendLine($"- 评估要点（Points）：{d.PointName}");
        sb.AppendLine($"- 评估参考点（Reference）：{d.ReferencePoint}");
        sb.AppendLine($"- 评估方法（Method）：{d.Method}");
        sb.AppendLine($"- 标准分（MaxScore）：{d.MaxScore}");
        sb.AppendLine();

        sb.AppendLine("【评分标准（ScoringItems）】");
        if (d.ScoringItems != null && d.ScoringItems.Any())
        {
            foreach (var s in d.ScoringItems)
            {
                sb.AppendLine($"- ScoringItemId={s.Id}; LevelCode={s.LevelCode}; Ratio={s.Ratio}; Desc={s.Description}");
            }
        }
        else
        {
            sb.AppendLine("- （无评分标准数据：请提示管理员补全评分标准）");
        }

        sb.AppendLine();
        sb.AppendLine("【你的任务】");
        sb.AppendLine("1) 阅读以上指标信息与评分标准。");
        sb.AppendLine("2) 阅读你收到的 PDF 佐证材料（这些 PDF 与当前指标对应）。");
        sb.AppendLine("3) 给出一个最合适的 ScoringItemId（必须是列表里出现过的），并给出理由。");
        sb.AppendLine("4) 给出 keyEvidence（3~8条）与 missingEvidence（0~8条）。");
        sb.AppendLine();
        sb.AppendLine("【输出要求】");
        sb.AppendLine("只输出 JSON（不要任何多余文字），JSON 字段必须包含：");
        sb.AppendLine("{");
        sb.AppendLine("  \"recommendedScoringItemId\": number,");
        sb.AppendLine("  \"recommendedLevelCode\": string,");
        sb.AppendLine("  \"confidence\": number,");
        sb.AppendLine("  \"keyEvidence\": [string],");
        sb.AppendLine("  \"missingEvidence\": [string],");
        sb.AppendLine("  \"explanation\": string");
        sb.AppendLine("}");

        return sb.ToString();
    }

    private static AiAssistResultDto ParseAiJson(string rawJson, NodeFillDetailDto detail)
    {
        var result = new AiAssistResultDto { RawJson = rawJson };

        try
        {
            using var doc = JsonDocument.Parse(rawJson);
            var root = doc.RootElement;

            if (root.TryGetProperty("recommendedScoringItemId", out var idEl) && idEl.ValueKind == JsonValueKind.Number)
                result.RecommendedScoringItemId = idEl.GetInt64();

            if (root.TryGetProperty("recommendedLevelCode", out var lvEl) && lvEl.ValueKind == JsonValueKind.String)
                result.RecommendedLevelCode = lvEl.GetString();

            if (root.TryGetProperty("confidence", out var cEl) && cEl.ValueKind == JsonValueKind.Number)
                result.Confidence = (decimal)cEl.GetDouble();

            if (root.TryGetProperty("explanation", out var expEl) && expEl.ValueKind == JsonValueKind.String)
                result.Explanation = expEl.GetString() ?? "";

            if (root.TryGetProperty("keyEvidence", out var keEl) && keEl.ValueKind == JsonValueKind.Array)
                result.KeyEvidence = keEl.EnumerateArray().Where(x => x.ValueKind == JsonValueKind.String).Select(x => x.GetString() ?? "").Where(x => x.Length > 0).ToList();

            if (root.TryGetProperty("missingEvidence", out var meEl) && meEl.ValueKind == JsonValueKind.Array)
                result.MissingEvidence = meEl.EnumerateArray().Where(x => x.ValueKind == JsonValueKind.String).Select(x => x.GetString() ?? "").Where(x => x.Length > 0).ToList();

            // 计算建议分（如果能匹配到 ScoringItemId）
            if (result.RecommendedScoringItemId.HasValue && detail.ScoringItems != null)
            {
                var hit = detail.ScoringItems.FirstOrDefault(x => x.Id == result.RecommendedScoringItemId.Value);
                if (hit != null)
                {
                    // Ratio 常见是 0~1
                    try
                    {
                        var ratio = Convert.ToDecimal(hit.Ratio);
                        var max = Convert.ToDecimal(detail.MaxScore);
                        if (ratio > 0 && ratio <= 1) result.RecommendedScore = Math.Round(max * ratio, 2);
                    }
                    catch
                    {
                        // ignore
                    }
                }
            }

            return result;
        }
        catch
        {
            // JSON 不合法：降级直接展示
            result.Explanation = rawJson;
            result.Confidence = 0;
            return result;
        }
    }
}
