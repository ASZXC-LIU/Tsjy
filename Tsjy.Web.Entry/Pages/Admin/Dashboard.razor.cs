using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Tsjy.Application.System.Dtos.BatchDtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Enums;
using Tsjy.Core.MyHelper; // 假设用于枚举扩展方法 GetDisplayName

namespace Tsjy.Web.Entry.Pages.Admin
{
    public partial class Dashboard
    {
        [Inject]
        [NotNull]
        private IBatchService? BatchService { get; set; }

        [Inject]
        [NotNull]
        private AuthenticationStateProvider? AuthenticationStateProvider { get; set; }

        // 活跃批次列表
        private List<BatchListDto> ActiveBatches { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            await LoadDashboardData();
        }

        private async Task LoadDashboardData()
        {
            // 获取所有批次 (includeDeleted = false)
            var allBatches = await BatchService.GetListAsync(null, false);

            // 筛选活跃批次：
            // 1. 未删除 (接口已过滤，但为了保险可再判断)
            // 2. 状态不是已完成 (Finished)
            // 按创建时间倒序，只显示前 5 条
            ActiveBatches = allBatches
                .Where(b => b.Status != PublicStatus.Finished)
                .OrderByDescending(b => b.CreatedAt)
                .Take(5)
                .ToList();
        }

        // 计算时间进度 (UploadStart -> InspectionEnd)
        private int CalculateTimeProgress(BatchListDto batch)
        {
            if (batch.UploadStart == null || batch.InspectionEnd == null) return 0;

            var start = batch.UploadStart.Value;
            var end = batch.InspectionEnd.Value;
            var now = DateTime.Now;

            // 尚未开始
            if (now < start) return 0;
            // 已经结束
            if (now > end) return 100;

            var totalTicks = (end - start).Ticks;
            var currentTicks = (now - start).Ticks;

            if (totalTicks <= 0) return 100;

            return (int)((double)currentTicks / totalTicks * 100);
        }

        // 获取当前阶段的文字描述
        private string GetStatusText(BatchListDto batch)
        {
            var now = DateTime.Now;

            if (now < batch.UploadStart)
                return "尚未开始";

            if (now >= batch.UploadStart && now <= batch.UploadEnd)
                return $"填报阶段 (截止: {batch.UploadEnd:MM-dd})";

            if (now > batch.UploadEnd && now < batch.ReviewStart)
                return "等待评审启动";

            if (now >= batch.ReviewStart && now <= batch.ReviewEnd)
                return $"专家评审阶段 (截止: {batch.ReviewEnd:MM-dd})";

            if (now > batch.ReviewEnd && now < batch.InspectionStart)
                return "等待视导启动";

            if (now >= batch.InspectionStart && now <= batch.InspectionEnd)
                return $"实地视导阶段 (截止: {batch.InspectionEnd:MM-dd})";

            if (now > batch.InspectionEnd)
                return "已过截止日期";

            return "进行中";
        }

        // 辅助获取类型名称
        private string GetTargetTypeName(OrgType type)
        {
            // 如果您有 EnumExtension，可以直接用 type.GetDisplayName()
            // 这里做一个简单的 switch 作为兜底
            return type switch
            {
                OrgType.SpecialSchool => "特殊教育学校",
                OrgType.InclusiveSchool => "康复中心",
                OrgType.EducationBureau => "职业学校",
                _ => "未知类型"
            };
        }
    }
}