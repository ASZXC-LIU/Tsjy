using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.BasicDataDtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Entities;

namespace Tsjy.Application.System.Service
{
    public class BasicDataService : ITransient, IDynamicApiController, IScoped,IBasicDataService // 自动注册服务
    {
        private readonly IRepository<Region> _regionRepo;
        private readonly IRepository<Departments> _deptRepo;

        public BasicDataService(IRepository<Region> regionRepo, IRepository<Departments> deptRepo)
        {
            _regionRepo = regionRepo;
            _deptRepo = deptRepo;
        }

        #region Region Management
        public async Task<List<RegionDto>> GetRegionsAsync()
        {
            var list = await _regionRepo.AsQueryable(false).OrderBy(x => x.Code).ToListAsync();
            return list.Adapt<List<RegionDto>>();
        }

        public async Task SaveRegionAsync(RegionDto dto)
        {
            var entity = dto.Adapt<Region>();

            // 检查是否存在
            var isExist = await _regionRepo.AnyAsync(x => x.Code == entity.Code);

            if (isExist)
            {
                // 存在则更新
                await _regionRepo.UpdateNowAsync(entity);
            }
            else
            {
                // 不存在则插入
                await _regionRepo.InsertNowAsync(entity);
            }
        }

        public async Task DeleteRegionAsync(string code)
        {
            var entity = await _regionRepo.FirstOrDefaultAsync(x => x.Code == code);
            if (entity != null)
            {
                entity.IsDeleted = true;
                await _regionRepo.UpdateNowAsync(entity);
            }
        }

        public async Task UpdateRegionStatusAsync(string code, bool isDeleted)
        {
            var entity = await _regionRepo.FirstOrDefaultAsync(x => x.Code == code);
            if (entity != null)
            {
                entity.IsDeleted = isDeleted;
                await _regionRepo.UpdateNowAsync(entity);
            }
        }
        #endregion

        #region Department Management
        public async Task<List<DepartmentDto>> GetDepartmentsAsync()
        {
            // 联表查询获取区域名称 (简单示例，如果数据量大建议优化)
            var list = await _deptRepo.AsQueryable(false)
                .OrderByDescending(x => x.CreatedAt)
                .ToListAsync();

            // 这里为了简单，假设前端不需要一次性加载所有RegionName，或者单独处理
            // 如果需要RegionName，最好先查Region表做一个Dict映射
            var regions = await _regionRepo.AsQueryable(false).Select(x => new { x.Code, x.Name }).ToListAsync();
            var regionDict = regions.ToDictionary(x => x.Code, x => x.Name);

            var dtos = list.Adapt<List<DepartmentDto>>();
            foreach (var item in dtos)
            {
                if (!string.IsNullOrEmpty(item.RegionCode) && regionDict.ContainsKey(item.RegionCode))
                {
                    item.RegionName = regionDict[item.RegionCode];
                }
            }
            return dtos;
        }

        public async Task SaveDepartmentAsync(DepartmentDto dto)
        {
            // 1. 尝试获取已存在的实体 (如果 Context 中已追踪，会直接返回追踪的实例)
            var existingEntity = await _deptRepo.FirstOrDefaultAsync(x => x.Code == dto.Code);

            if (existingEntity != null)
            {
                // 2. 如果存在：将 DTO 的值更新到这个已被追踪的实体上
                // Mapster 的 Adapt 方法支持将源对象的数据覆盖到目标对象
                dto.Adapt(existingEntity);

                // 3. 保存更新 (因为 existingEntity 已经被追踪，UpdateNowAsync 会处理得很好)
                await _deptRepo.UpdateNowAsync(existingEntity);
            }
            else
            {
                // 4. 如果不存在：这是一个新插入的操作
                var newEntity = dto.Adapt<Departments>();
                await _deptRepo.InsertNowAsync(newEntity);
            }
        }

        public async Task DeleteDepartmentAsync(string code)
        {
            await _deptRepo.DeleteNowAsync(code);
        }

        public async Task UpdateDepartmentStatusAsync(string code, bool isDeleted)
        {
            var entity = await _deptRepo.FirstOrDefaultAsync(x => x.Code == code);
            if (entity != null)
            {
                entity.IsDeleted = isDeleted;
                await _deptRepo.UpdateNowAsync(entity);
            }
        }
        #endregion
    }
}