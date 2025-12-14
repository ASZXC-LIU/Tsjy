using System.Diagnostics.CodeAnalysis;
using BootstrapBlazor.Components;
using Furion.DatabaseAccessor;
using Mapster;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.IService;
using Tsjy.Application.System.Service;
using Tsjy.Core.Entities;
namespace Tsjy.Web.Entry.Pages.Admin
{
    public partial class ScoringModels
    {
        [Inject]
        [NotNull]
        private IScoringModelService? ScoringService { get; set; }
        [Inject]
        [NotNull]
        private ToastService? Toast { get; set; }
        [Inject]
        private IServiceScopeFactory ScopeFactory { get; set; }
        // 编辑弹窗绑定的 DTO
        private ScoringModelDto EditModel { get; set; } = new();
        [Inject]
        [NotNull]
        private SwalService? Swal { get; set; } // 注入 Swal 用于弹窗


      

        /// <summary>
        /// 表格查询数据
        /// </summary>
        private async Task<QueryData<ScoringModel>> OnQueryAsync(QueryPageOptions options)
        {
            // 获取全量列表（后端做了 IsDeleted 过滤）
            // 如果数据量大，建议后端改为分页接口，这里演示用 GetList
            var items = await ScoringService.GetList();

            // 处理前端搜索/排序/分页
            // BootstrapBlazor 提供了 QueryHelper 来在内存中处理这些，适合中小数据量
            var total = items.Count;
            var pagedItems = items.Skip((options.PageIndex - 1) * options.PageItems).Take(options.PageItems).ToList();

            return new QueryData<ScoringModel>
            {
                Items = pagedItems,
                TotalCount = total
            };
        }
        /// <summary>
        /// 点击“新建”按钮时触发
        /// </summary>
        private Task<ScoringModel> OnAddAsync()
        {
            // 1. 清空 EditModel，确保表单干净
            EditModel = new ScoringModelDto
            {
                // 初始化默认值，比如默认给两行
                Items = new List<ScoringModelItemDto>
                {
                    new ScoringModelItemDto { Ratio = 1.0m, Description = "优秀" },
                    new ScoringModelItemDto { Ratio = 0.8m, Description = "良好" }
                }
            };

            // 2. 返回一个新的实体对象给 Table 组件（虽然我们在用 DTO，但这步是必须的格式）
            return Task.FromResult(new ScoringModel());
        }

        // 同时，你的 OnEditAsync 可以简化了，因为 else 分支已经不会被“新建”按钮触发了
        private async Task<bool> OnEditAsync(ScoringModel model)
        {
            try
            {
                // 1. 从数据库查出详情（包含 Items）
                // 注意：这里必须 Include(x => x.Items)，否则弹窗里看不到等级列表
                // 假设你的 Service 已经处理了 Include，如果没处理，建议直接在这里用 Repo 查

                using var scope = ScopeFactory.CreateScope();
                var repo = scope.ServiceProvider.GetRequiredService<IRepository<ScoringModel>>();

                var entity = await repo.Include(u => u.Items)
                                       .FirstOrDefaultAsync(u => u.Id == model.Id);

                // 2. 转换为 DTO 供前端绑定
                EditModel = entity.Adapt<ScoringModelDto>();

                return true;
            }
            catch (Exception ex)
            {
                await Toast.Error("加载失败", ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 点击弹窗“保存”时触发
        /// </summary>
       
        /// <summary>
        /// 点击“删除”按钮时触发
        /// </summary>
        private async Task<bool> OnDeleteAsync(IEnumerable<ScoringModel> items)
        {
            try
            {
                // 1. 检查选中的项
                if (!items.Any()) return false;

                // 2. 循环删除
                foreach (var item in items)
                {
                    // 建议：在 Service 层增加一个 CheckIsUsed 方法
                    // var isUsed = await ScoringService.IsModelUsed(item.Id);
                    // if (isUsed) throw new Exception($"模板 {item.Name} 正在被指标使用，无法删除！");

                    await ScoringService.Delete(item.Id);
                }

                await Toast.Success("删除成功");
                return true; // 返回 true 会让表格自动刷新 UI
            }
            catch (Exception ex)
            {
                // 3. 重点：如果是外键冲突，给用户明确提示
                if (ex.InnerException != null && ex.InnerException.Message.Contains("FOREIGN KEY"))
                {
                    await Swal.Show(new SwalOption()
                    {
                        Category = SwalCategory.Error,
                        Title = "无法删除",
                        Content = "该评分模板正在被评价指标使用，请先解除关联或删除对应指标后再试。"
                    });
                }
                else
                {
                    await Toast.Error("删除失败", ex.Message);
                }
                return false; // 返回 false，表格不会移除该行
            }
        }

        

    }
}