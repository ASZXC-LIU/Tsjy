using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BootstrapBlazor.Components;
using Microsoft.Extensions.DependencyInjection;

namespace Tsjy.Web.Core.DataService
{
    /// <summary>
    /// EFCore ORM 注入服务扩展类
    /// </summary>
    public static class DataAccessServicesExtensions
    {
        public static IServiceCollection AddEFCoreDataAccessServices(this IServiceCollection services)
        {
            // 增加数据服务
            services.AddSingleton(typeof(DataServiceBase<>), typeof(EntityFrameworkDataService<>));
            return services;
        }
    }
}
