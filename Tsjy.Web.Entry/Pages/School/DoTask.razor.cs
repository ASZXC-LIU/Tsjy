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

    // 当前选中的节点填报详情
    private NodeFillDetailDto CurrentNodeDetail { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await LoadTree();
    }

    private async Task LoadTree()
    {
        var nodes = await TaskService.GetTaskTree(TaskId);
        // 将扁平的 DTO 列表递归转换为 BootstrapBlazor 的 TreeViewItem
        TreeItems = BuildTreeItems(nodes, null);
    }

    /// <summary>
    /// 点击树节点事件
    /// </summary>
    private async Task OnNodeClick(TreeViewItem<TaskNodeTreeDto> item)
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
        }
    }

    /// <summary>
    /// 保存并提交
    /// </summary>
    private async Task OnSaveEvidence()
    {
        if (CurrentNodeDetail == null) return;

        // 简单校验
        if (string.IsNullOrWhiteSpace(CurrentNodeDetail.MyContent) && !CurrentNodeDetail.FileUrls.Any())
        {
            await MessageService.Show(new MessageOption { Content = "请至少填写自评说明或上传一份附件", Color = Color.Warning });
            return;
        }

        await TaskService.SubmitEvidence(CurrentNodeDetail);

        await MessageService.Show(new MessageOption { Content = "提交成功！", Color = Color.Success });

        // 更新左侧树的状态图标 (设为已完成)
        UpdateTreeStatus(TreeItems, CurrentNodeDetail.NodeId);
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
        foreach (var item in items)
        {
            if (item.Value.Id == nodeId)
            {
                item.Value.IsCompleted = true;
                // 强制刷新 Template 的一种方式是重新赋值（BB可能有更优解，这里简单处理）
                item.Template = CreateNodeTemplate(item.Value);
                return;
            }
            if (item.Items.Any())
            {
                UpdateTreeStatus(item.Items, nodeId);
            }
        }
    }

    // 定义树节点显示的模板 (显示勾号)
    private RenderFragment<TaskNodeTreeDto> CreateNodeTemplate(TaskNodeTreeDto node) => (TaskNodeTreeDto item) => (RenderTreeBuilder builder) =>
    {
        // 注意：虽然方法参数传入了 node，但作为模板，建议使用 Lambda 参数 item (它们在这里是同一个对象)
        builder.OpenElement(0, "span");
        builder.AddContent(1, item.Code + " " + item.Name);
        builder.CloseElement();

        if (item.IsCompleted)
        {
            builder.OpenElement(2, "i");
            builder.AddAttribute(3, "class", "fa fa-check-circle text-success ms-2");
            builder.CloseElement();
        }
        else if (item.AuditStatus == AuditStatus.Rejected)
        {
            builder.OpenElement(4, "i");
            builder.AddAttribute(5, "class", "fa fa-exclamation-circle text-danger ms-2");
            builder.CloseElement();
        }
    };
    #endregion
}