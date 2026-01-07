using System.Security.Claims;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Forms;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.InspectionDtos;
using Tsjy.Application.System.IService;
using Tsjy.Application.System.Service;
using Tsjy.Core.Enums;
namespace Tsjy.Web.Entry.Pages.Inspection;

public partial class DoInspection
{
    [Parameter] public long ScheduleId { get; set; }
    [Parameter] public long TaskId { get; set; } // 用于查指标树

    [Inject] private IEvalNodeService NodeService { get; set; }
    [Inject] private IInspectionService InspectionService { get; set; }
    [Inject] private FileService FileService { get; set; } // 用于物理上传文件
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
        if (node.Type == EvalNodeType.Points)
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

        // 设置最大上传大小 (与 FileService.cs 中的 MaxSize 保持一致或更小)
        long maxFileSize = 20 * 1024 * 1024; // 20MB

        foreach (var file in e.GetMultipleFiles())
        {
            try
            {
                // 1. 打开文件流
                // 注意：Blazor 的 OpenReadStream 需要指定最大允许大小，否则超过默认值(512KB)会报错
                using var stream = file.OpenReadStream(maxFileSize);

                // 2. 调用 FileService 中已有的正确方法
                // 参数：流, 文件名, 任务ID, 节点ID (用于生成存储路径 uploads/evidences/{TaskId}/{NodeId})
                var url = await FileService.SaveEvidenceFromBrowserFile(
                    stream,
                    file.Name,
                    TaskId,
                    CurrentNode.Id
                );

                // 3. 添加到当前页面的列表
                if (!string.IsNullOrEmpty(url))
                {
                    LogModel.FileUrls.Add(url);
                }
            }
            catch (Exception ex)
            {
                // 建议：处理文件过大或非PDF的异常提示
                await MessageService.Show(new MessageOption
                {
                    Content = $"上传失败: {ex.Message}",
                    Color = Color.Danger
                });
            }
        }

        // 只有在成功添加文件后才提示成功
        if (LogModel.FileUrls.Count > 0)
        {
            await MessageService.Show(new MessageOption { Content = "文件已添加，请记得点击保存", Color = Color.Success });
        }
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