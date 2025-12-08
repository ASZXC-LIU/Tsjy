using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Furion.DynamicApiController;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Entities;

namespace Tsjy.Application.System.Service
{
    /// <summary>
    /// 评分模板管理服务
    /// </summary>
    public class ScoringModelService : IDynamicApiController, IScoped, IScoringModelService
    {
        // 注入主表仓储，EF Core 会自动处理关联的 Items 子表
        private readonly IRepository<ScoringModel> _modelRepo;

        public ScoringModelService(IRepository<ScoringModel> modelRepo)
        {
            _modelRepo = modelRepo;
        }

        #region 查询接口

        /// <summary>
        /// 获取所有模板列表 (用于管理页面表格)
        /// </summary>
        [HttpGet("api/scoring/page")]
        public async Task<List<ScoringModel>> GetList()
        {
            // 列表页只查主表，过滤掉已删除的
            return await _modelRepo.Where(x => !x.IsDeleted)
                                   .OrderByDescending(x => x.CreatedAt)
                                   .ToListAsync();
        }

        /// <summary>
        /// 获取下拉框选项 (用于新建评价指标时的下拉选择)
        /// </summary>
        [HttpGet("api/scoring/options")]
        public async Task<List<ScoringModel>> GetOptions()
        {
            return await _modelRepo.Where(x => !x.IsDeleted)
                                   .OrderByDescending(x => x.CreatedAt)
                                   .ToListAsync();
        }

        /// <summary>
        /// 获取单个模板详情 (用于编辑时的回显)
        /// </summary>
        [HttpGet("api/scoring/{id}")]
        public async Task<ScoringModelDto> GetDetail([Required] long id)
        {
            // ★★★ 关键：使用 Include 加载子表 Items ★★★
            var entity = await _modelRepo.Include(x => x.Items)
                                         .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null) throw new Exception("模板不存在");

            return new ScoringModelDto
            {
                Id = entity.Id,
                Name = entity.Name,
                // 按 Sort 排序，确保前端回显顺序正确 (A, B, C...)
                Items = entity.Items
                              .Where(i => !i.IsDeleted)
                              .OrderBy(i => i.Sort)
                              .Select(i => new ScoringModelItemDto
                              {
                                  Id = i.Id,
                                  LevelCode = i.LevelCode,
                                  Ratio = i.Ratio,
                                  Description = i.Description
                              }).ToList()
            };
        }

        #endregion

        #region 写入接口

        /// <summary>
        /// 保存模板 (新增或修改)
        /// </summary>
        [HttpPost("api/scoring/save")]
        public async Task<long> Save([FromBody] ScoringModelDto input)
        {
            // 1. 核心算法：自动排序并生成 A/B/C
            // 无论前端怎么传，先按系数从大到小排序 (1.0 -> 0.8 -> 0.6)
            var sortedInputItems = input.Items.OrderByDescending(x => x.Ratio).ToList();

            // 准备新的实体列表
            var newEntityItems = new List<ScoringModelItem>();
            for (int i = 0; i < sortedInputItems.Count; i++)
            {
                var item = sortedInputItems[i];
                newEntityItems.Add(new ScoringModelItem
                {
                    // 自动生成 LevelCode: 0->A, 1->B, 2->C ...
                    LevelCode = ((char)('A' + i)).ToString(),
                    Ratio = item.Ratio,
                    Description = item.Description,
                    Sort = i,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    IsDeleted = false
                });
            }

            if (input.Id > 0)
            {
                // --- 修改模式 ---
                var entity = await _modelRepo.Include(x => x.Items)
                                             .FirstOrDefaultAsync(x => x.Id == input.Id);

                if (entity == null) throw new Exception("未找到要修改的模板");

                // 1. 更新主表
                entity.Name = input.Name;
                entity.UpdatedAt = DateTime.Now;

                // 2. 更新子表 (最稳妥策略：移除旧的，添加新的)
                // EF Core 会自动识别并执行 DELETE 和 INSERT
                if (entity.Items != null && entity.Items.Any())
                {
                    _modelRepo.Context.RemoveRange(entity.Items);
                    entity.Items.Clear();
                }

                // 将新生成的列表加入
                entity.Items.AddRange(newEntityItems);

                await _modelRepo.UpdateAsync(entity);
                return entity.Id;
            }
            else
            {
                // --- 新增模式 ---
                var entity = new ScoringModel
                {
                    Name = input.Name,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    Items = newEntityItems // 直接赋值，EF Core 会级联插入
                };

                await _modelRepo.InsertAsync(entity);
                return entity.Id;
            }
        }

        /// <summary>
        /// 删除模板 (软删除)
        /// </summary>
        [HttpPost("api/scoring/delete")]
        public async Task Delete([Required] long id)
        {
            var entity = await _modelRepo.FindOrDefaultAsync(id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.UpdatedAt = DateTime.Now;
                await _modelRepo.UpdateAsync(entity);
            }
        }

        #endregion
    }
}