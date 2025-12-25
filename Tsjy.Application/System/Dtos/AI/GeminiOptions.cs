using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsjy.Application.System.Dtos.AI;

public sealed class GeminiOptions
{
    /// <summary>Gemini Developer API Key（不要提交到仓库）</summary>
    public string ApiKey { get; set; } = string.Empty;

    /// <summary>模型名，例如：gemini-3-pro-preview</summary>
    public string Model { get; set; } = "gemini-3-pro-preview";

    /// <summary>最多读取多少个 PDF（避免一次塞太多）</summary>
    public int MaxPdfFiles { get; set; } = 5;

    /// <summary>每个 PDF 最大读取字节（默认 20MB）</summary>
    public int MaxPdfBytes { get; set; } = 20 * 1024 * 1024;

    /// <summary>温度，越低越稳定</summary>
    public double Temperature { get; set; } = 0.1;

    /// <summary>最大输出 token</summary>
    public int MaxOutputTokens { get; set; } = 1200;
}
