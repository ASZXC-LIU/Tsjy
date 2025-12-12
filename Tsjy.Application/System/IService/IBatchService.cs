using Furion.DatabaseAccessor;
using Tsjy.Application.System.Dtos.BatchDtos;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.IService;

public interface IBatchService
{
    // 修改：增加 includeDeleted 参数
    Task<List<BatchListDto>> GetListAsync(OrgType? orgType = null, bool includeDeleted = false);
    Task DeleteAsync(long id);
    // 这个方法名虽然叫 UpdateStatus，但实际现在是更新启用/禁用状态(IsDeleted)
    Task UpdateStatusAsync(long id, bool isEnabled);
    Task UpdateAsync(BatchInputDto input);
    Task CreateAsync(BatchInputDto input);
}