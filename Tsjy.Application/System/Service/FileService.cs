using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.RegularExpressions;
using Tsjy.Application.System.Service; // 仅为了保持你的项目引用一致
using SystemIO = System.IO;
using System.Net;
namespace Tsjy.Application.System.Service;

/// <summary>
/// 文件服务：
/// 1) UploadEvidence(IFormFile) —— 保持你原来 API 上传方式可用（如果别处用到）
/// 2) SaveEvidenceFromBrowserFile(Stream...) —— 供 Blazor Server 组件直接注入调用（不走 HttpClient）
/// 3) GetEvidenceList/DeleteEvidence —— 目录级列表与删除（按 taskId+nodeId）
///
/// 注意：当前仍存放在 wwwroot/uploads/evidences 下（与原项目一致）
/// </summary>
public class FileService : IDynamicApiController, ITransient
{
    private const long MaxSize = 20 * 1024 * 1024; // 20MB
    private static readonly Regex SafeNameRegex = new(@"[^\w\-.()（）【】\u4e00-\u9fa5 ]+", RegexOptions.Compiled);

    private readonly IWebHostEnvironment _environment;

    public FileService(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    // ------------------------
    // ① 你原来的 API 上传（保留）
    // ------------------------
    [HttpPost]
    [Authorize(Roles = "SchoolUser")]
    public async Task<string> UploadEvidence([FromForm] IFormFile file, [FromQuery] long taskId, [FromQuery] long nodeId)
    {
        if (file == null || file.Length == 0) throw new Exception("文件为空");
        if (file.Length > MaxSize) throw new Exception("单文件最大 20MB");

        var ext = SystemIO.Path.GetExtension(file.FileName).ToLowerInvariant();
        if (ext != ".pdf") throw new Exception("只允许上传 PDF 文件");

        // PDF 魔数校验（轻量）
        await using (var s = file.OpenReadStream())
        {
            var head = new byte[4];
            var read = await s.ReadAsync(head, 0, 4);
            if (read < 4 || Encoding.ASCII.GetString(head) != "%PDF")
                throw new Exception("文件内容不是有效 PDF");
        }

        var (physicalDir, relativeDir) = EnsureEvidenceDir(taskId, nodeId);

        var original = SafeNameRegex.Replace(SystemIO.Path.GetFileName(file.FileName), "_");
        if (!original.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase)) original += ".pdf";

        var storedName = $"{Guid.NewGuid():N}_{original}";
        var physicalPath = SystemIO.Path.Combine(physicalDir, storedName);

        await using (var stream = SystemIO.File.Create(physicalPath))
        {
            await file.CopyToAsync(stream);
        }

        return $"/{relativeDir.Replace("\\", "/")}/{storedName}";
    }

    // -----------------------------------------
    // ② Blazor Server 组件直接注入调用的保存方法
    // -----------------------------------------
    public async Task<string> SaveEvidenceFromBrowserFile(
        Stream stream,
        string fileName,
        long taskId,
        long nodeId)
    {
        if (stream == null) throw new Exception("文件流为空");
        if (string.IsNullOrWhiteSpace(fileName)) throw new Exception("文件名为空");

        var ext = SystemIO.Path.GetExtension(fileName).ToLowerInvariant();
        if (ext != ".pdf") throw new Exception("只允许上传 PDF 文件");

        // PDF 魔数校验：读取前 4 字节，再把流位置归零（如果不支持 Seek，就不归零）
        if (stream.CanSeek)
        {
            var pos = stream.Position;
            stream.Position = 0;
            var head = new byte[4];
            var read = await stream.ReadAsync(head, 0, 4);
            stream.Position = 0; // 归位
            if (read < 4 || Encoding.ASCII.GetString(head) != "%PDF")
                throw new Exception("文件内容不是有效 PDF");
        }

        var (physicalDir, relativeDir) = EnsureEvidenceDir(taskId, nodeId);

        var original = SafeNameRegex.Replace(SystemIO.Path.GetFileName(fileName), "_");
        if (!original.EndsWith(".pdf", StringComparison.OrdinalIgnoreCase)) original += ".pdf";

        var storedName = $"{Guid.NewGuid():N}_{original}";
        var physicalPath = SystemIO.Path.Combine(physicalDir, storedName);

        // 覆盖保护：正常不会撞名；如果真撞了就再生成一次
        if (SystemIO.File.Exists(physicalPath))
        {
            storedName = $"{Guid.NewGuid():N}_{original}";
            physicalPath = SystemIO.Path.Combine(physicalDir, storedName);
        }

        await using (var fs = SystemIO.File.Create(physicalPath))
        {
            await stream.CopyToAsync(fs);
        }

        return $"/{relativeDir.Replace("\\", "/")}/{storedName}";
    }

    // -------------------------
    // ③ 列表：按 taskId+nodeId
    // -------------------------
    [HttpGet]
    public Task<List<string>> GetEvidenceList([FromQuery] long taskId, [FromQuery] long nodeId)
    {
        var (physicalDir, relativeDir) = EnsureEvidenceDir(taskId, nodeId);

        if (!SystemIO.Directory.Exists(physicalDir))
            return Task.FromResult(new List<string>());

        var files = SystemIO.Directory.GetFiles(physicalDir, "*.pdf", SearchOption.TopDirectoryOnly)
            .OrderByDescending(SystemIO.File.GetLastWriteTimeUtc)
            .Select(p => SystemIO.Path.GetFileName(p))
            .Where(name => !string.IsNullOrWhiteSpace(name))
            .Select(name => $"/{relativeDir.Replace("\\", "/")}/{name}")
            .ToList();

        return Task.FromResult(files);
    }

    // -------------------------
    // ④ 删除：按 taskId+nodeId+fileKey
    // -------------------------
    [HttpDelete]
    [Authorize(Roles = "SchoolUser")]
    public Task DeleteEvidence([FromQuery] long taskId, [FromQuery] long nodeId, [FromQuery] string fileKey)
    {
        var (physicalDir, _) = EnsureEvidenceDir(taskId, nodeId);

        // 防止路径穿越：只取文件名
        var safeName = SystemIO.Path.GetFileName(Uri.UnescapeDataString(fileKey ?? ""));
        if (string.IsNullOrWhiteSpace(safeName)) return Task.CompletedTask;

        var physicalPath = SystemIO.Path.Combine(physicalDir, safeName);
        if (SystemIO.File.Exists(physicalPath))
            SystemIO.File.Delete(physicalPath);

        return Task.CompletedTask;
    }

    // -------------------------
    // 私有：确保目录存在
    // -------------------------
    private (string physicalDir, string relativeDir) EnsureEvidenceDir(long taskId, long nodeId)
    {
        // 相对目录：uploads/evidences/{taskId}/{nodeId}
        var relativeDir = SystemIO.Path.Combine("uploads", "evidences", taskId.ToString(), nodeId.ToString());

        // 物理 wwwroot
        var webRoot = _environment.WebRootPath;
        if (string.IsNullOrWhiteSpace(webRoot))
        {
            webRoot = SystemIO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot");
        }

        var physicalDir = SystemIO.Path.Combine(webRoot, relativeDir);
        SystemIO.Directory.CreateDirectory(physicalDir);

        return (physicalDir, relativeDir);
    }

    /// <summary>
    /// 供服务端内部（AI/页面）使用：直接枚举某 taskId+nodeId 目录下的 PDF URL 列表
    /// </summary>
    public List<string> GetEvidenceUrlList(long taskId, long nodeId)
    {
        var (physicalDir, relativeDir) = EnsureEvidenceDir(taskId, nodeId);

        if (!SystemIO.Directory.Exists(physicalDir))
            return new List<string>();

        var files = SystemIO.Directory.GetFiles(physicalDir, "*.pdf", SearchOption.TopDirectoryOnly)
            .OrderByDescending(SystemIO.File.GetLastWriteTimeUtc)
            .Select(p => SystemIO.Path.GetFileName(p))
            .Where(name => !string.IsNullOrWhiteSpace(name))
            .ToList();

        return files.Select(name => BuildUrl(relativeDir, name)).ToList();
    }
    /// <summary>
    /// 供 AI 读取本地文件：把站内 URL（/uploads/...）解析成物理路径（wwwroot/...）
    /// 只允许解析 uploads 目录下的站内路径，避免任意文件读取。
    /// </summary>
    public string? TryResolvePhysicalPathFromUrl(string url)
    {
        if (string.IsNullOrWhiteSpace(url)) return null;

        var rel = url.Trim();

        // 1) 只允许站内路径
        if (!rel.StartsWith("/")) return null;

        // 2) 去掉 query（保险）
        var q = rel.IndexOf('?');
        if (q >= 0) rel = rel[..q];

        // 3) 统一分隔符（保险）
        rel = rel.Replace('\\', '/');

        // 4) 只允许 uploads 目录，防止乱读
        if (!rel.StartsWith("/uploads/", StringComparison.OrdinalIgnoreCase)) return null;

        // ✅ 5) 关键：把 %E9%BB%91... 解码成 黑白...
        rel = WebUtility.UrlDecode(rel);

        var webRoot = _environment.WebRootPath;
        if (string.IsNullOrWhiteSpace(webRoot))
            webRoot = SystemIO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "wwwroot");

        var physical = SystemIO.Path.Combine(
            webRoot,
            rel.TrimStart('/').Replace("/", SystemIO.Path.DirectorySeparatorChar.ToString()));

        return physical;
    }
    private static string BuildUrl(string relativeDir, string fileName)
    {
        // relativeDir 可能是 "uploads\\evidences\\1\\2"
        var dir = (relativeDir ?? "").Replace("\\", "/").Trim('/');
        var name = Uri.EscapeDataString(fileName ?? "");
        return $"/{dir}/{name}";
    }
}
