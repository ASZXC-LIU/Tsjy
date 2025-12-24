using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Pages.School;

public partial class DoTask
{
    [Parameter] public long TaskId { get; set; }
    private bool IsEditable { get; set; } = false;
    [Inject] private TaskService TaskService { get; set; }
    [Inject] private MessageService MessageService { get; set; }
    [Inject] private NavigationManager NavigationManager { get; set; }

    private List<TreeViewItem<TaskNodeTreeDto>> TreeItems { get; set; } = new();
    private bool IsLoading { get; set; } = true;
    private NodeFillDetailDto CurrentNodeDetail { get; set; }
    private readonly SemaphoreSlim _semaphore = new(1, 1);

    // 任务整体状态
    private TaskStatu CurrentTaskStatus { get; set; }

    // 当前节点是否允许编辑
    private bool IsNodeEditable { get; set; } = false;

    // ★★★ 修复点：代码必须在大括号内 ★★★
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
        catch (Exception)
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
            // 高亮处理
            foreach (var treeItem in TreeItems)
            {
                treeItem.IsActive = (treeItem == item);
            }

            if (item.Value.Type == EvalNodeType.Points)
            {
                CurrentNodeDetail = await TaskService.GetNodeFillDetail(TaskId, item.Value.Id);

                // ★★★ 核心修复：权限判断逻辑 ★★★
                if (CurrentTaskStatus == TaskStatu.Returned)
                {
                    // 场景A：任务被退回 -> 只有状态为 "驳回" 的节点可编辑
                    IsNodeEditable = CurrentNodeDetail.Status == AuditStatus.Rejected;
                }
                else
                {
                    // 场景B：正常填报 -> 看全局 IsEditable (时间符合 && 状态符合)
                    IsNodeEditable = IsEditable;
                }
            }
            else
            {
                CurrentNodeDetail = null;
                IsNodeEditable = false;
            }
            StateHasChanged();
        }
        catch (Exception)
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

            if (string.IsNullOrWhiteSpace(CurrentNodeDetail.MyContent) && !CurrentNodeDetail.FileUrls.Any())
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
        {
            await GoToNextNode();
        }
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
            await Task.Delay(500);
            NavigationManager.NavigateTo("/School/MyTasks");
        }
    }

    public void Dispose()
    {
        _semaphore?.Dispose();
        GC.SuppressFinalize(this);
    }

    private async Task OnUploadFile(UploadFile file)
    {
        if (file.Code == 0)
        {
            CurrentNodeDetail.FileUrls.Add(file.FileName);
        }
        await Task.CompletedTask;
    }

    private void RemoveFile(string fileName)
    {
        CurrentNodeDetail.FileUrls.Remove(fileName);
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
}