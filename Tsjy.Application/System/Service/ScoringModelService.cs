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
        private readonly IRepository<ScoringModel> _modelRepo;

        public ScoringModelService(IRepository<ScoringModel> modelRepo)
        {
            _modelRepo = modelRepo;
        }

        #region 查询接口（保持不变）

        [HttpGet("api/scoring/page")]
        public async Task<List<ScoringModel>> GetList()
        {
            return await _modelRepo.Where(x => !x.IsDeleted)
                                   .OrderByDescending(x => x.CreatedAt)
                                   .ToListAsync();
        }

        [HttpGet("api/scoring/options")]
        public async Task<List<ScoringModel>> GetOptions()
        {
            return await _modelRepo.Where(x => !x.IsDeleted)
                                   .OrderByDescending(x => x.CreatedAt)
                                   .ToListAsync();
        }

        [HttpGet("api/scoring/{id}")]
        public async Task<ScoringModelDto> GetDetail([Required] long id)
        {
            var entity = await _modelRepo.Include(x => x.Items)
                                         .FirstOrDefaultAsync(x => x.Id == id);

            if (entity == null) throw new Exception("模板不存在");

            return new ScoringModelDto
            {
                Id = entity.Id,
                Name = entity.Name,
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

        #region 写入接口（关键：加 [UnitOfWork]）

        /// <summary>
        /// 保存模板 (新增或修改)
        /// </summary>
        [UnitOfWork]                // ⭐⭐ 关键：加事务 + 自动 SaveChanges
        [HttpPost("api/scoring/save")]
        public async Task Save([FromBody] ScoringModelDto input)
        {
            // 重新排序 items，并生成 LevelCode / Sort
            var sortedItems = input.Items.OrderByDescending(x => x.Ratio).ToList();

            var newEntityItems = new List<ScoringModelItem>();
            for (int i = 0; i < sortedItems.Count; i++)
            {
                newEntityItems.Add(new ScoringModelItem
                {
                    LevelCode = ((char)('A' + i)).ToString(),
                    Ratio = sortedItems[i].Ratio,
                    Description = sortedItems[i].Description,
                    Sort = i,
                    IsDeleted = false
                });
            }

            if (input.Id > 0)
            {
                // 修改
                var entity = await _modelRepo.Include(x => x.Items)
                                             .FirstOrDefaultAsync(x => x.Id == input.Id);

                if (entity == null) throw new Exception("模板不存在");

                entity.Name = input.Name;
                entity.UpdatedAt = DateTime.Now;

                // 清空旧子项
                if (entity.Items != null && entity.Items.Any())
                {
                    _modelRepo.Context.RemoveRange(entity.Items);
                }

                // 重新赋值子项
                entity.Items = newEntityItems;

                await _modelRepo.UpdateAsync(entity);
                // 有 [UnitOfWork]，方法结束时会自动 SaveChanges
            }
            else
            {
                // 新增
                var entity = new ScoringModel
                {
                    Name = input.Name,
                    Items = newEntityItems,
                    IsDeleted = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                await _modelRepo.InsertAsync(entity);
                // 同上，自动 SaveChanges
            }
        }

        /// <summary>
        /// 删除模板（软删除）
        /// </summary>
        [UnitOfWork]                // ⭐⭐ 同样需要提交事务
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
