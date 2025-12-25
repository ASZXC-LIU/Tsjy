using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Furion.ConfigurableOptions;

namespace Tsjy.Application.System.Dtos.AI;

public sealed class QwenOptions : IConfigurableOptions
{
    public string ApiKey { get; set; } = "sk-df015159c669480a89c572d0579623e7"; // 或者读环境变量 DASHSCOPE_API_KEY
    public string BaseUrl { get; set; } = "https://dashscope.aliyuncs.com/compatible-mode/v1"; // 北京
    public string Model { get; set; } = "qwen-long"; // 
    public float Temperature { get; set; } = 0.2f;
    public int MaxOutputTokens { get; set; } = 2048;
    public int MaxPdfFiles { get; set; } = 3;
    public long MaxPdfBytes { get; set; } = 10 * 1024 * 1024;
}
