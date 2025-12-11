using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsjy.Application.System.Dtos.BasicDataDtos;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.IService
{
    public interface IBasicDataService
    {
 
        Task<List<RegionDto>> GetRegionsAsync();
        Task SaveRegionAsync(RegionDto dto);
        Task DeleteRegionAsync(string code);
        Task<List<DepartmentDto>> GetDepartmentsAsync();
        Task SaveDepartmentAsync(DepartmentDto dto);
        Task DeleteDepartmentAsync(string code);
        Task UpdateRegionStatusAsync(string code, bool isDeleted);
        Task UpdateDepartmentStatusAsync(string code, bool isDeleted);
    }
}
