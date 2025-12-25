using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Furion.DynamicApiController;
using Furion.DependencyInjection;
// ★ 使用别名避开 Tsjy.Application.System 的冲突
using SystemIO = System.IO;

namespace Tsjy.Application.System.Service;

/// <summary>
/// 附件管理服务
/// </summary>
public class FileService : IDynamicApiController, ITransient
{
    private readonly IWebHostEnvironment _environment;

    public FileService(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    /// <summary>
    /// 物理保存 PDF 佐证材料
    /// </summary>
    [HttpPost]
    public async Task<string> UploadEvidence([FromForm] IFormFile file, [FromQuery] long taskId, [FromQuery] long nodeId)
    {
        // 1. 后缀校验
        var ext = SystemIO.Path.GetExtension(file.FileName).ToLower();
        if (ext != ".pdf") throw new Exception("只允许上传 PDF 格式文件。");

        // 2. 确定物理路径：wwwroot/uploads/evidences/{TaskId}/{NodeId}
        var relativeDir = SystemIO.Path.Combine("uploads", "evidences", taskId.ToString(), nodeId.ToString());

        // 自动获取 wwwroot 路径，若为空（如初始化阶段）则手动构造
        var webRoot = _environment.WebRootPath;
        if (string.IsNullOrEmpty(webRoot))
        {
            webRoot = SystemIO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "wwwroot");
        }

        var physicalDir = SystemIO.Path.Combine(webRoot, relativeDir);

        // 如果目录不存在则创建（逐级创建）
        if (!SystemIO.Directory.Exists(physicalDir))
        {
            SystemIO.Directory.CreateDirectory(physicalDir);
        }

        // 3. 生成唯一文件名，防止重名
        var safeFileName = $"{Guid.NewGuid():N}_{file.FileName}";
        var physicalPath = SystemIO.Path.Combine(physicalDir, safeFileName);

        // 4. 执行物理保存
        using (var stream = SystemIO.File.Create(physicalPath))
        {
            await file.CopyToAsync(stream);
        }

        // 5. 返回 Web 可访问的相对路径 (将 Windows 路径分隔符转换为 Web 的正斜杠)
        return $"/{relativeDir.Replace("\\", "/")}/{safeFileName}";
    }
}