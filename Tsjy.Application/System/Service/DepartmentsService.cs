using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootstrapBlazor.Components;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Service
{
    public class DepartmentsService : IDynamicApiController, ITransient
    {
        private readonly IRepository<Departments> _orgRepo;


        public DepartmentsService(
          
          IRepository<Departments> orgRepo // Update
          )
        {
           
            _orgRepo = orgRepo;
           
        }


        // Tsjy.Application.System.Service.TaskService.cs

        /// <summary>
        /// 根据机构类型获取下拉框列表
        /// </summary>
        public async Task<List<SelectedItem>> GetOrgSelectListAsync(OrgType type)
        {
            // 注意：这里使用的是 Departments 表
            var list = await _orgRepo.AsQueryable()
                .Where(d => d.OrgType == type && !d.IsDeleted)
                .Select(d => new
                {
                    d.Code,
                    d.Name
                })
                .ToListAsync();

            // 转换为 BootstrapBlazor 需要的 SelectedItem 格式
            // Value = Code (存入 SysUsers.OrgId), Text = Name (显示)
            return list.Select(x => new SelectedItem(x.Code, x.Name)).ToList();
        }
    }

}
