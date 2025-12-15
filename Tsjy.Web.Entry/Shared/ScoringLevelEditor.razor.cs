using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tsjy.Application.System.Dtos;

namespace Tsjy.Web.Entry.Shared;

public partial class ScoringLevelEditor : ValidateBase<List<ScoringModelItemDto>>
{
    protected override void OnInitialized()
    {
        base.OnInitialized();
        if (Value == null) Value = new List<ScoringModelItemDto>();
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (Value == null) Value = new List<ScoringModelItemDto>();
    }

    private async Task OnAddItem()
    {
        if (Value == null) Value = new List<ScoringModelItemDto>();

        // 智能计算默认系数：取当前最小系数减 0.2
        decimal nextRatio = 0.6m;
        if (Value.Any())
        {
            var minRatio = Value.Min(x => x.Ratio);
            nextRatio = minRatio >= 0.2m ? minRatio - 0.2m : 0m;
        }

        var newItem = new ScoringModelItemDto
        {
            Id = -DateTime.Now.Ticks, // 临时ID
            Ratio = nextRatio,
            Description = "",
            LevelCode = ""
        };

        Value.Add(newItem);
        await TriggerChange();
    }

    private async Task OnRemoveItem(ScoringModelItemDto item)
    {
        if (Value != null && Value.Contains(item))
        {
            Value.Remove(item);
            await TriggerChange();
        }
    }

    private async Task TriggerChange()
    {
        if (ValueChanged.HasDelegate)
        {
            await ValueChanged.InvokeAsync(Value);
        }
        StateHasChanged();
    }

    /// <summary>
    /// 根据索引生成 A, B, C...
    /// </summary>
    private string GetLevelChar(int index)
    {
        if (index < 0) return "?";
        // 简单处理 A-Z，超过则 AA (虽然评分一般不会超过26级)
        if (index < 26) return ((char)('A' + index)).ToString();
        return "N";
    }

    /// <summary>
    /// 获取头像颜色样式
    /// </summary>
    private string GetLevelColorClass(string levelChar)
    {
        return levelChar switch
        {
            "A" => "level-A", // 蓝
            "B" => "level-B", // 绿
            "C" => "level-C", // 黄
            "D" => "level-D", // 红
            _ => "bg-light text-secondary" // 灰
        };
    }
}