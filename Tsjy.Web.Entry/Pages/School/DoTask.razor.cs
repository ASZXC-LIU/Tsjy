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
    [Inject] private NavigationManager NavigationManager { get; set; } // 注入导航服务 (需求 5)

    private List<TreeViewItem<TaskNodeTreeDto>> TreeItems { get; set; } = new();
    private bool IsLoading { get; set; } = true;
    private NodeFillDetailDto CurrentNodeDetail { get; set; }
    private readonly SemaphoreSlim _semaphore = new(1, 1);
    private TaskStatu CurrentTaskStatus { get; set; }

    // [新增] 当前选中的节点是否允许编辑 (控制按钮显示)
    private bool IsNodeEditable { get; set; } = false;
    protected override async Task OnInitializedAsync()
    {
        // 所有逻辑都必须放在大括号里面
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
                Icon = "fa fa-file-pen", // 默认图标
                Items = new List<TreeViewItem<TaskNodeTreeDto>>(),
                Template = CreateNodeTemplate(node) // 使用自定义模板
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
            // 更新选中状态的高亮
            foreach (var treeItem in TreeItems)
            {
                treeItem.IsActive = (treeItem == item);
            }

            if (item.Value.Type == EvalNodeType.Points)
            {
                CurrentNodeDetail = await TaskService.GetNodeFillDetail(TaskId, item.Value.Id);
                if (CurrentTaskStatus == TaskStatu.Returned)
                {
                    // 场景A：任务被退回 -> 只有状态为 "驳回" 的节点可编辑
                    // 注意：CurrentNodeDetail.Status 是佐证材料的审核状态
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
        // 1. 先执行保存逻辑
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

            // 更新树上当前节点的完成状态图标
            var currentTreeItem = TreeItems.FirstOrDefault(x => x.Value.Id == CurrentNodeDetail.NodeId);
            if (currentTreeItem != null)
            {
                currentTreeItem.Value.IsCompleted = true;
                currentTreeItem.Template = CreateNodeTemplate(currentTreeItem.Value); // 刷新图标
            }

            saveSuccess = true;
            await MessageService.Show(new MessageOption { Content = "保存成功，正在跳转下一项...", Color = Color.Success });
        }
        finally
        {
            _semaphore.Release();
        }

        // 2. 如果保存成功，执行自动跳转 (需求 5)
        // 注意：这里要在释放锁之后执行，因为 OnNodeClick 内部也会获取锁
        if (saveSuccess)
        {
            await GoToNextNode();
        }
    }

    /// <summary>
    /// 跳转到下一个节点逻辑
    /// </summary>
    private async Task GoToNextNode()
    {
        if (CurrentNodeDetail == null) return;

        // 在扁平列表中找到当前索引
        var currentIndex = TreeItems.FindIndex(x => x.Value.Id == CurrentNodeDetail.NodeId);

        // 检查是否有下一个
        if (currentIndex >= 0 && currentIndex < TreeItems.Count - 1)
        {
            var nextItem = TreeItems[currentIndex + 1];
            // 触发点击事件加载下一个
            await OnNodeClick(nextItem);
        }
        else
        {
            // 如果已经是最后一个，跳转回任务列表
            await Task.Delay(500); // 稍微停顿给用户看保存成功的提示
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

    /// <summary>
    /// 构建树节点模板 (核心需求 3：固定长度省略号)
    /// </summary>
    /// <summary>
    /// 构建树节点模板
    /// </summary>
    private RenderFragment<TaskNodeTreeDto> CreateNodeTemplate(TaskNodeTreeDto node) => (TaskNodeTreeDto item) => (RenderTreeBuilder builder) =>
    {
        // 拼接显示文本：如果有编号则显示 "编号 名称"，否则只显示名称
        string displayText = string.IsNullOrEmpty(item.Code) ? item.Name : $"{item.Code} {item.Name}";

        builder.OpenElement(0, "div");
        builder.AddAttribute(1, "class", "node-wrapper"); // 对应 CSS 中的 .node-wrapper

        // 1. 左侧图标 (固定宽度)
        builder.OpenElement(2, "i");
        // 根据是否完成显示不同颜色的图标
        string iconClass = item.IsCompleted
            ? "fa fa-file-circle-check text-success"
            : "fa fa-file-pen text-secondary opacity-50";
        builder.AddAttribute(3, "class", iconClass);
        builder.CloseElement();

        // 2. 文本区域 (自适应宽度 + 截断)
        builder.OpenElement(4, "div");
        builder.AddAttribute(5, "class", "node-text"); // 对应 CSS 中的 .node-text
        builder.AddAttribute(6, "title", displayText); // ★关键：鼠标悬停显示完整文字
        builder.AddContent(7, displayText);
        builder.CloseElement();

        // 3. 右侧状态图标 (例如：驳回状态)
        if (item.AuditStatus == AuditStatus.Rejected)
        {
            builder.OpenElement(8, "i");
            builder.AddAttribute(9, "class", "fa fa-circle-exclamation text-danger ms-1");
            builder.AddAttribute(10, "title", "已驳回");
            builder.CloseElement();
        }

        builder.CloseElement(); // 关闭 node-wrapper
    };
}