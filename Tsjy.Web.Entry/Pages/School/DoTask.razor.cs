using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;
using System.IO;

namespace Tsjy.Web.Entry.Pages.School;

public partial class DoTask : IDisposable
{
    [Parameter] public long TaskId { get; set; }

    [Inject] private TaskService TaskService { get; set; }
    [Inject] private FileService FileService { get; set; }
    [Inject] private MessageService MessageService { get; set; }
    [Inject] private NavigationManager NavigationManager { get; set; }

    private List<UploadFile> UploadedFiles { get; set; } = new();
    private List<TreeViewItem<TaskNodeTreeDto>> TreeItems { get; set; } = new();
    private bool IsLoading { get; set; } = true;

    private NodeFillDetailDto? CurrentNodeDetail { get; set; }
    private readonly SemaphoreSlim _semaphore = new(1, 1);

    private bool IsEditable { get; set; } = false;
    private TaskStatu CurrentTaskStatus { get; set; }
    private bool IsNodeEditable { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        CurrentTaskStatus = await TaskService.GetTaskStatus(TaskId);
        IsEditable = await TaskService.IsTaskEditable(TaskId);
        await LoadTree();
    }

    private async Task LoadTree()
    {
        IsLoading = true;
        try
        {
            var nodes = await TaskService.GetTaskTree(TaskId);
            var pointNodes = nodes.Where(x => x.Type == EvalNodeType.Points)
                                  .OrderBy(x => x.Code)
                                  .ToList();

            TreeItems = pointNodes.Select(node => new TreeViewItem<TaskNodeTreeDto>(node)
            {
                Text = string.IsNullOrEmpty(node.Code) ? node.Name : $"{node.Code} {node.Name}",
                Icon = "fa fa-file-pen",
                Items = new List<TreeViewItem<TaskNodeTreeDto>>(),
                Template = CreateNodeTemplate(node)
            }).ToList();
        }
        catch
        {
            await MessageService.Show(new MessageOption { Content = "加载指标数据失败", Color = Color.Danger });
        }
        finally
        {
            IsLoading = false;
        }
    }

    private async Task OnNodeClick(TreeViewItem<TaskNodeTreeDto> item)
    {
        await _semaphore.WaitAsync();
        try
        {
            foreach (var treeItem in TreeItems)
                treeItem.IsActive = (treeItem == item);

            if (item.Value.Type != EvalNodeType.Points)
            {
                CurrentNodeDetail = null;
                IsNodeEditable = false;
                UploadedFiles = new();
                StateHasChanged();
                return;
            }

            // 1) 指标详情
            CurrentNodeDetail = await TaskService.GetNodeFillDetail(TaskId, item.Value.Id);

            // 2) 该指标目录下的 PDF 列表（不走 HttpClient）
            var serverFiles = await FileService.GetEvidenceList(TaskId, CurrentNodeDetail.NodeId);
            CurrentNodeDetail.FileUrls = serverFiles;

            UploadedFiles = serverFiles.Select(url => new UploadFile
            {
                PrevUrl = url,
                FileName = Path.GetFileName(url)
            }).ToList();

            // 3) 可编辑规则（保持你原逻辑）
            if (CurrentTaskStatus == TaskStatu.Returned)
            {
                IsNodeEditable = CurrentNodeDetail.Status == AuditStatus.Rejected;
            }
            else
            {
                IsNodeEditable = IsEditable;
            }

            StateHasChanged();
        }
        catch
        {
            await MessageService.Show(new MessageOption { Content = "加载详情失败", Color = Color.Danger });
        }
        finally
        {
            _semaphore.Release();
        }
    }

    private async Task OnSaveEvidence()
    {
        bool saveSuccess = false;

        await _semaphore.WaitAsync();
        try
        {
            if (CurrentNodeDetail == null) return;

            var hasText = !string.IsNullOrWhiteSpace(CurrentNodeDetail.MyContent);
            var hasFiles = CurrentNodeDetail.FileUrls != null && CurrentNodeDetail.FileUrls.Any();
            if (!hasText && !hasFiles)
            {
                await MessageService.Show(new MessageOption { Content = "请填写内容或上传附件", Color = Color.Warning });
                return;
            }

            await TaskService.SubmitEvidence(CurrentNodeDetail);

            // 更新树图标
            var currentTreeItem = TreeItems.FirstOrDefault(x => x.Value.Id == CurrentNodeDetail.NodeId);
            if (currentTreeItem != null)
            {
                currentTreeItem.Value.IsCompleted = true;
                currentTreeItem.Template = CreateNodeTemplate(currentTreeItem.Value);
            }

            saveSuccess = true;
            await MessageService.Show(new MessageOption { Content = "保存成功，正在跳转下一项...", Color = Color.Success });
        }
        catch (Exception ex)
        {
            await MessageService.Show(new MessageOption { Content = ex.Message, Color = Color.Danger });
        }
        finally
        {
            _semaphore.Release();
        }

        if (saveSuccess)
            await GoToNextNode();
    }

    private async Task GoToNextNode()
    {
        if (CurrentNodeDetail == null) return;
        var currentIndex = TreeItems.FindIndex(x => x.Value.Id == CurrentNodeDetail.NodeId);
        if (currentIndex >= 0 && currentIndex < TreeItems.Count - 1)
        {
            var nextItem = TreeItems[currentIndex + 1];
            await OnNodeClick(nextItem);
        }
        else
        {
            await Task.Delay(300);
            NavigationManager.NavigateTo("/School/MyTasks");
        }
    }

    // DropUpload：上传触发（不走 HttpClient）
    private async Task OnUploadChanged(UploadFile file)
    {
        if (CurrentNodeDetail == null) return;

        if (!IsNodeEditable)
        {
            await MessageService.Show(new MessageOption { Content = "当前指标不可编辑，无法上传", Color = Color.Warning });
            return;
        }

        if (file.File == null)
        {
            await MessageService.Show(new MessageOption { Content = "未获取到文件内容", Color = Color.Danger });
            return;
        }

        var ext = Path.GetExtension(file.File.Name);
        if (!string.Equals(ext, ".pdf", StringComparison.OrdinalIgnoreCase))
        {
            await MessageService.Show(new MessageOption { Content = "仅允许上传 PDF 文件", Color = Color.Warning });
            return;
        }

        try
        {
            await using var stream = file.File.OpenReadStream(20 * 1024 * 1024);

            var url = await FileService.SaveEvidenceFromBrowserFile(
                stream,
                file.File.Name,
                TaskId,
                CurrentNodeDetail.NodeId);

            CurrentNodeDetail.FileUrls ??= new List<string>();
            if (!CurrentNodeDetail.FileUrls.Contains(url))
                CurrentNodeDetail.FileUrls.Add(url);

            if (!UploadedFiles.Any(x => x.PrevUrl == url))
                UploadedFiles.Add(new UploadFile { PrevUrl = url, FileName = Path.GetFileName(url) });

            await MessageService.Show(new MessageOption { Content = "上传成功", Color = Color.Success });
            StateHasChanged();
        }
        catch (Exception ex)
        {
            await MessageService.Show(new MessageOption { Content = $"上传失败：{ex.Message}", Color = Color.Danger });
        }
    }

    // DropUpload：删除触发（删除物理文件 + 列表移除）
    private async Task<bool> OnDeleteFile(UploadFile file)
    {
        if (CurrentNodeDetail == null) return false;

        if (!IsNodeEditable)
        {
            await MessageService.Show(new MessageOption { Content = "当前指标不可编辑，无法删除", Color = Color.Warning });
            return false;
        }

        try
        {
            var prev = file.PrevUrl ?? "";
            var idx = prev.LastIndexOf('/');
            var fileKey = idx >= 0 ? prev[(idx + 1)..] : prev;

            await FileService.DeleteEvidence(TaskId, CurrentNodeDetail.NodeId, fileKey);

            CurrentNodeDetail.FileUrls?.Remove(file.PrevUrl);
            UploadedFiles.RemoveAll(x => x.PrevUrl == file.PrevUrl);

            return true;
        }
        catch (Exception ex)
        {
            await MessageService.Show(new MessageOption { Content = $"删除失败：{ex.Message}", Color = Color.Danger });
            return false;
        }
    }

    private RenderFragment<TaskNodeTreeDto> CreateNodeTemplate(TaskNodeTreeDto node) => (TaskNodeTreeDto item) => (RenderTreeBuilder builder) =>
    {
        string displayText = string.IsNullOrEmpty(item.Code) ? item.Name : $"{item.Code} {item.Name}";
        builder.OpenElement(0, "div");
        builder.AddAttribute(1, "class", "node-wrapper");

        builder.OpenElement(2, "i");
        string iconClass = item.IsCompleted
            ? "fa fa-file-circle-check text-success"
            : "fa fa-file-pen text-secondary opacity-50";
        builder.AddAttribute(3, "class", iconClass);
        builder.CloseElement();

        builder.OpenElement(4, "div");
        builder.AddAttribute(5, "class", "node-text");
        builder.AddAttribute(6, "title", displayText);
        builder.AddContent(7, displayText);
        builder.CloseElement();

        if (item.AuditStatus == AuditStatus.Rejected)
        {
            builder.OpenElement(8, "i");
            builder.AddAttribute(9, "class", "fa fa-circle-exclamation text-danger ms-1");
            builder.AddAttribute(10, "title", "已驳回");
            builder.CloseElement();
        }

        builder.CloseElement();
    };

    public void Dispose()
    {
        _semaphore?.Dispose();
        GC.SuppressFinalize(this);
    }
}
