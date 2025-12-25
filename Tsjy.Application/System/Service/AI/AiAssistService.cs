using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Furion.DependencyInjection;
using Microsoft.Extensions.Options;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.AI;
using Tsjy.Application.System.Dtos.ReviewDtos;
using Tsjy.Application.System.IService;
using Tsjy.Application.System.Service;
using Tsjy.Application.System.Service.AI;
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
    private readonly IOptions<QwenOptions> _opt;
    private readonly TaskService _taskService;
    private readonly FileService _fileService;

    public AiAssistService(IOptions<QwenOptions> opt, TaskService taskService, FileService fileService)
    {
        _opt = opt;
        _taskService = taskService;
        _fileService = fileService;
    }

    public async Task<AiAssistResultDto> ExpertAssistAsync(long taskId, long nodeId, CancellationToken ct = default)
    {
        // 1) 指标信息
        NodeFillDetailDto detail = await _taskService.GetNodeFillDetail(taskId, nodeId);

        // 2) 本地 PDF（只取本指标目录）
        var opt = _opt.Value; // 这里建议你把 GeminiOptions 换成 QwenOptions（下面我会给）
        var urls = _fileService.GetEvidenceUrlList(taskId, nodeId);

        var physicalFiles = urls
            .Select(u => _fileService.TryResolvePhysicalPathFromUrl(u))
            .Where(p => !string.IsNullOrWhiteSpace(p) && SystemIO.File.Exists(p!))
            .Take(opt.MaxPdfFiles)
            .Cast<string>()
            .ToList();
        Console.WriteLine($"[AI] urls.count={urls?.Count ?? 0}");
        if (urls != null)
        {
            foreach (var u in urls)
            {
                var p = _fileService.TryResolvePhysicalPathFromUrl(u);
                Console.WriteLine($"[AI] url={u}");
                Console.WriteLine($"[AI] resolved={p}");
                Console.WriteLine($"[AI] exists={(p != null && SystemIO.File.Exists(p))}");
            }
        }
        Console.WriteLine($"[AI] physicalFiles.count={physicalFiles.Count}");
        // 3) 组织 Prompt（严格要求 JSON 输出）
        var prompt = BuildPrompt(detail);

        // 4) 把 PDF 佐证材料转成“文本输入”
        var evidenceText = await PdfTextExtractor.ExtractEvidenceTextAsync(
    physicalFiles,
    new PdfExtractOptions
    {
        MaxPdfBytes = opt.MaxPdfBytes,
        MaxCharsPerPdf = 12000,
        MaxCharsTotal = 40000,
        MinTextCharsToSkipOcr = 200,
        MaxOcrPages = 3,
        OcrDpi = 200,
        TessdataPath = "Resources/tessdata",
        OcrLang = "chi_sim+eng"
    },
    ct);

        // 5) 调用通义千问（DashScope OpenAI兼容接口）
        var apiKey = string.IsNullOrWhiteSpace(opt.ApiKey)
            ? Environment.GetEnvironmentVariable("DASHSCOPE_API_KEY")
            : opt.ApiKey;

        if (string.IsNullOrWhiteSpace(apiKey))
            throw new Exception("通义千问 API Key 未配置（Qwen:ApiKey 或环境变量 DASHSCOPE_API_KEY）");

        var baseUrl = string.IsNullOrWhiteSpace(opt.BaseUrl)
            ? "https://dashscope.aliyuncs.com/compatible-mode/v1"
            : opt.BaseUrl.TrimEnd('/');

        var url = $"{baseUrl}/chat/completions";

        var reqBody = new
        {
            model = opt.Model, // 例如：qwen-plus / qwen-max / qwen-long
            messages = new object[]
            {
            new { role = "system", content = "你是中国教育评价体系的评审专家。只依据提供材料，不允许臆测；缺失要明确指出。" },
            new { role = "user", content = prompt + "\n\n【PDF佐证材料】\n" + evidenceText }
            },
            temperature = opt.Temperature,
            max_tokens = opt.MaxOutputTokens
        };

        using var http = new HttpClient();
        http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
        http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        var json = JsonSerializer.Serialize(reqBody);
        using var content = new StringContent(json, Encoding.UTF8, "application/json");

        using var resp = await http.PostAsync(url, content, ct);
        var raw = await resp.Content.ReadAsStringAsync(ct);

        if (!resp.IsSuccessStatusCode)
            throw new Exception($"AI 调用失败：{(int)resp.StatusCode} {resp.ReasonPhrase}\n{raw}");

        // OpenAI兼容格式：choices[0].message.content
        using var doc = JsonDocument.Parse(raw);
        var text = doc.RootElement
            .GetProperty("choices")[0]
            .GetProperty("message")
            .GetProperty("content")
            .GetString();

        if (string.IsNullOrWhiteSpace(text))
            throw new Exception("AI 未返回内容（choices[0].message.content 为空）");

        return ParseAiJson(text, detail);
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
