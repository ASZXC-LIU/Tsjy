namespace Tsjy.Application.System.Dtos.AI;

public sealed class AiAssistResultDto
{
    public long? RecommendedScoringItemId { get; set; }
    public string? RecommendedLevelCode { get; set; }

    /// <summary>按 MaxScore * Ratio 计算出来的建议分（如果你 Ratio 是 0~1）</summary>
    public decimal? RecommendedScore { get; set; }

    /// <summary>0~1</summary>
    public decimal Confidence { get; set; }

    public List<string> KeyEvidence { get; set; } = new();
    public List<string> MissingEvidence { get; set; } = new();

    /// <summary>给页面显示的解释（Markdown/纯文本都行）</summary>
    public string Explanation { get; set; } = string.Empty;

    /// <summary>模型原始 JSON（方便你排错）</summary>
    public string RawJson { get; set; } = string.Empty;
}