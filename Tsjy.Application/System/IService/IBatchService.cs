using Furion.DatabaseAccessor;
using Tsjy.Application.System.Dtos.BatchDtos;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.IService;

public interface IBatchService
{
    Task<List<BatchListDto>> GetListAsync(OrgType? orgType = null);
    Task DeleteAsync(long id);
    Task UpdateStatusAsync(long id, bool isEnabled);
    Task UpdateAsync(BatchInputDto input);
}