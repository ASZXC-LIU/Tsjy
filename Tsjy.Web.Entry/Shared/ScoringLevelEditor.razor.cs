using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Tsjy.Application.System.Dtos;

namespace Tsjy.Web.Entry.Shared;

public partial class ScoringLevelEditor : ValidateBase<List<ScoringModelItemDto>>
{
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (Value == null) Value = new List<ScoringModelItemDto>();
    }

    private async Task OnAddItem()
    {
        if (Value == null) Value = new List<ScoringModelItemDto>();

        var newItem = new ScoringModelItemDto
        {
            // 使用负数 tick 作为临时 ID，避免 Key 重复
            Id = -DateTime.Now.Ticks,

            // 系数默认值，可以给个 0.8 之类的
            Ratio = 0.8m,

            Description = "",
            LevelCode = "" // 后端生成
        };

        Value.Add(newItem);

        if (ValueChanged.HasDelegate)
        {
            await ValueChanged.InvokeAsync(Value);
        }

        StateHasChanged();
    }

    private async Task OnRemoveItem(ScoringModelItemDto item)
    {
        if (Value != null && Value.Contains(item))
        {
            Value.Remove(item);

            if (ValueChanged.HasDelegate)
            {
                await ValueChanged.InvokeAsync(Value);
            }

            StateHasChanged();
        }
    }
}