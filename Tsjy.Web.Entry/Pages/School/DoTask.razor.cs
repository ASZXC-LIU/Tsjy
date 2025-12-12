using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;
using Microsoft.AspNetCore.Components.Rendering;
namespace Tsjy.Web.Entry.Pages.School;

public partial class DoTask
{
    [Parameter] public long TaskId { get; set; }

    [Inject] private TaskService TaskService { get; set; }
    [Inject] private MessageService MessageService { get; set; }

    // 树形结构数据
    private List<TreeViewItem<TaskNodeTreeDto>> TreeItems { get; set; } = new();
    private bool IsLoading { get; set; } = true;
    // 当前选中的节点填报详情
    private NodeFillDetailDto CurrentNodeDetail { get; set; }
    private readonly SemaphoreSlim _semaphore = new(1, 1);
    protected override async Task OnInitializedAsync()
    {
        await LoadTree();
    }

    private async Task LoadTree()
    {
        // 开始加载前置为 true
        IsLoading = true;
        try
        {
            var nodes = await TaskService.GetTaskTree(TaskId);
            var pointNodes = nodes.Where(x => x.Type == EvalNodeType.Points)
                                  // 按 1.1, 1.2 这种序号排序
                                  .OrderBy(x => x.Code)
                                  .ToList();
            // 将扁平的 DTO 列表递归转换为 BootstrapBlazor 的 TreeViewItem
            TreeItems = pointNodes.Select(node => new TreeViewItem<TaskNodeTreeDto>(node)
            {
                // 显示序号+名称
                Text = string.IsNullOrEmpty(node.Code) ? node.Name : $"{node.Code} {node.Name}",
                // 给个图标区分
                Icon = "fa fa-file-pen",
                // 默认就当作叶子节点
                Items = new List<TreeViewItem<TaskNodeTreeDto>>(),
                // 自定义模板用于显示“已完成”勾号
                Template = CreateNodeTemplate(node)
            }).ToList();
        }
        catch (Exception ex)
        {
            // 可选：处理异常，例如弹出错误提示
            await MessageService.Show(new MessageOption { Content = "加载指标数据失败", Color = Color.Danger });
        }
        finally
        {
            // 无论成功还是失败（或数据为空），都结束加载状态
            IsLoading = false;
        }
    }

    /// <summary>
    /// 点击树节点事件
    /// </summary>
    private async Task OnNodeClick(TreeViewItem<TaskNodeTreeDto> item)
    {
        // 只有类型为 "Points" (评估要点) 的节点才允许填报
        await _semaphore.WaitAsync();

        try
        {
            // 只有类型为 "Points" (评估要点) 的节点才允许填报
            if (item.Value.Type == EvalNodeType.Points)
            {
                // 加载详情
                CurrentNodeDetail = await TaskService.GetNodeFillDetail(TaskId, item.Value.Id);
                StateHasChanged();
            }
            else
            {
                CurrentNodeDetail = null; //如果不允许填报，清空右侧
                StateHasChanged();
            }
        }
        catch (Exception ex)
        {
            await MessageService.Show(new MessageOption { Content = "加载详情失败，请稍后重试", Color = Color.Danger });
        }
        finally
        {
            // ★★★ 核心修复：释放锁 ★★★
            _semaphore.Release();
        }
    }

    /// <summary>
    /// 保存并提交
    /// </summary>
    private async Task OnSaveEvidence()
    {
        // 提交操作同样建议加锁，防止重复提交
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
            await MessageService.Show(new MessageOption { Content = "保存成功！", Color = Color.Success });

            // 更新左侧图标状态
            var treeItem = TreeItems.FirstOrDefault(x => x.Value.Id == CurrentNodeDetail.NodeId);
            if (treeItem != null)
            {
                treeItem.Value.IsCompleted = true;
                treeItem.Template = CreateNodeTemplate(treeItem.Value); // 刷新图标
            }
        }
        finally
        {
            _semaphore.Release();
        }
    }
    public void Dispose()
    {
        _semaphore?.Dispose();
        GC.SuppressFinalize(this);
    }
    // 模拟文件上传回调
    private async Task OnUploadFile(UploadFile file)
    {
        if (file.Code == 0) // 假设0是成功
        {
            // 在这里调用你的实际上传接口，这里仅模拟将文件名加入列表
            // 实际开发中应该先 Upload 拿到 URL
            CurrentNodeDetail.FileUrls.Add(file.FileName);

            // 重要：UploadFile 组件如果是自动上传模式，这里无需手动处理流；
            // 如果是手动模式，需要处理 file.File Stream
        }
        await Task.CompletedTask;
    }

    private void RemoveFile(string fileName)
    {
        CurrentNodeDetail.FileUrls.Remove(fileName);
    }

    #region 辅助方法

    // 递归构建树
    private List<TreeViewItem<TaskNodeTreeDto>> BuildTreeItems(List<TaskNodeTreeDto> allNodes, long? parentId)
    {
        // 根节点的 ParentId 通常为 null 或 0，根据你的数据调整
        var children = allNodes.Where(x => x.ParentId == parentId || (parentId == null && (x.ParentId == 0 || x.ParentId == null)))
                               .OrderBy(x => x.OrderIndex)
                               .ToList();

        var items = new List<TreeViewItem<TaskNodeTreeDto>>();

        foreach (var node in children)
        {
            var item = new TreeViewItem<TaskNodeTreeDto>(node)
            {
                Text = node.Name,
                IsExpand = parentId == null, // 默认展开第一级
                Template = CreateNodeTemplate(node) // 设置自定义模板显示状态图标
            };

            var childItems = BuildTreeItems(allNodes, node.Id);
            if (childItems.Any())
            {
                item.Items = childItems;
            }
            items.Add(item);
        }

        return items;
    }

    // 更新树节点状态为“已完成”
    private void UpdateTreeStatus(List<TreeViewItem<TaskNodeTreeDto>> items, long nodeId)
    {
        var item = items.FirstOrDefault(x => x.Value.Id == nodeId);
        if (item != null)
        {
            item.Value.IsCompleted = true;
            // 重新赋值 Template 以触发 UI 刷新图标
            item.Template = CreateNodeTemplate(item.Value);
        }
    }

    // 定义树节点显示的模板 (显示勾号)
    private RenderFragment<TaskNodeTreeDto> CreateNodeTemplate(TaskNodeTreeDto node) => (TaskNodeTreeDto item) => (RenderTreeBuilder builder) =>
    {
        // 注意：虽然方法参数传入了 node，但作为模板，建议使用 Lambda 参数 item (它们在这里是同一个对象)
        builder.OpenElement(0, "div");
        builder.AddAttribute(1, "class", "d-flex align-items-center w-100");

        builder.OpenElement(2, "span");
        builder.AddAttribute(3, "class", "flex-grow-1 text-truncate");
        builder.AddContent(4, string.IsNullOrEmpty(item.Code) ? item.Name : $"{item.Code} {item.Name}");
        builder.CloseElement();

        if (item.IsCompleted)
        {
            builder.OpenElement(5, "i");
            builder.AddAttribute(6, "class", "fa fa-check-circle text-success ms-2");
            builder.CloseElement();
        }
        else if (item.AuditStatus == AuditStatus.Rejected)
        {
            builder.OpenElement(7, "i");
            builder.AddAttribute(8, "class", "fa fa-exclamation-circle text-danger ms-2");
            builder.CloseElement();
        }

        builder.CloseElement();
    };
    #endregion
}