using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System.Diagnostics.CodeAnalysis;
using Tsjy.Application.System.Dtos.BatchDtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Enums;

namespace Tsjy.Web.Entry.Shared;

public partial class BatchMonitorWidget : BootstrapComponentBase
{
    [Parameter]
    public long BatchId { get; set; }

    [Inject]
    [NotNull]
    private IBatchService? BatchService { get; set; }

    private BatchProgressDetailDto Data { get; set; } = new();
    private bool IsLoading { get; set; } = true;

    protected override async Task OnInitializedAsync()
    {
        IsLoading = true;
        try
        {
            if (BatchService != null)
            {
                Data = await BatchService.GetProgressDetailAsync(BatchId);
            }
        }
        finally
        {
            IsLoading = false;
        }
    }

    private Color GetStatusColor(TaskStatu status) => status switch
    {
        TaskStatu.NotStarted => Color.Secondary,
        TaskStatu.Submitted => Color.Success,
        TaskStatu.Submitting => Color.Primary,
        _ => Color.Info
    };
}