using System.Security.Claims;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.InspectionDtos;
using Tsjy.Application.System.IService;
using Tsjy.Application.System.Service;

namespace Tsjy.Web.Entry.Pages.Inspection;

public partial class DoInspection
{
    [Parameter] public long ScheduleId { get; set; }
    [Parameter] public long TaskId { get; set; } // 用于查指标树

    [Inject] private IEvalNodeService NodeService { get; set; }
    [Inject] private IInspectionService InspectionService { get; set; }
    [Inject] private IFileService FileService { get; set; } // 用于物理上传文件
    [Inject] private AuthenticationStateProvider AuthStateProvider { get; set; }
    [Inject] private MessageService MessageService { get; set; }

    private List<TreeViewItem<EvalNodeTreeDto>> TreeItems { get; set; }
    private EvalNodeTreeDto CurrentNode { get; set; }
    private InspectionLogInputDto LogModel { get; set; } = new();
    private string CurrentUserId { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var state = await AuthStateProvider.GetAuthenticationStateAsync();
        CurrentUserId = state.User.FindFirst(ClaimTypes.Sid)?.Value;

        // 加载指标树
        // 假设 NodeService 有 GetEvalTreeAsync 方法
        var nodes = await NodeService.GetEvalTreeAsync(TaskId);
        TreeItems = ConvertToTreeItems(nodes);
    }

    private List<TreeViewItem<EvalNodeTreeDto>> ConvertToTreeItems(List<EvalNodeTreeDto> nodes)
    {
        return nodes.Select(n => new TreeViewItem<EvalNodeTreeDto>(n)
        {
            Text = n.Name,
            Items = ConvertToTreeItems(n.Children),
            IsExpand = true
        }).ToList();
    }

    private async Task OnTreeItemClick(TreeViewItem<EvalNodeTreeDto> item)
    {
        var node = item.Value;
        // 只有 Points 类型才允许操作
        if (node.Type == Core.Enums.EvalNodeType.Points)
        {
            CurrentNode = node;
            // 加载已保存的数据 (基于 ScheduleId + NodeId)
            LogModel = await InspectionService.GetNodeLogAsync(ScheduleId, node.Id);
            StateHasChanged();
        }
        else
        {
            CurrentNode = null; // 上级节点不显示操作区
        }
    }

    private async Task OnUploadFile(InputFileChangeEventArgs e)
    {
        if (CurrentNode == null) return;

        foreach (var file in e.GetMultipleFiles())
        {
            // 1. 调用 FileService 将文件物理保存到服务器
            // 假设 UploadEvidenceAsync 返回文件的相对路径 URL
            // 注意：这里我们不需要像学校那样生成 Evidence 表记录，或者我们可以生成但不需要 Audit 流程
            // 简单起见，利用现有的 FileService 存文件并拿回 URL
            var url = await FileService.UploadFileOnlyAsync(file, "inspections");

            // 2. 添加到当前页面的列表
            if (!string.IsNullOrEmpty(url))
            {
                LogModel.FileUrls.Add(url);
            }
        }
        await MessageService.Show(new MessageOption { Content = "文件已添加，请记得点击保存", Color = Color.Success });
    }

    private void RemoveFile(string url)
    {
        LogModel.FileUrls.Remove(url);
    }

    private async Task SaveData()
    {
        if (CurrentNode == null) return;

        LogModel.ScheduleId = ScheduleId;
        LogModel.NodeId = CurrentNode.Id;

        // 调用 Service 保存到 inspection_logs 表
        await InspectionService.SaveNodeLogAsync(LogModel, CurrentUserId);

        await MessageService.Show(new MessageOption { Content = "保存成功", Color = Color.Success });
    }

    private string GetFileName(string url)
    {
        if (string.IsNullOrEmpty(url)) return "";
        return Path.GetFileName(url);
    }
}