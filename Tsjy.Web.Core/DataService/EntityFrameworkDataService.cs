using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BootstrapBlazor.Components;
using Microsoft.EntityFrameworkCore;
using Tsjy.EntityFramework.Core;


namespace Tsjy.Web.Core.DataService
{
    //数据访问类,需要提前注入DbFactory
    public class EntityFrameworkDataService<TModel> : DataServiceBase<TModel> where TModel : class
    {
        private IDbContextFactory<DefaultDbContext> _dbfactory { get; }

        public EntityFrameworkDataService(IDbContextFactory<DefaultDbContext> dbfactory) => _dbfactory = dbfactory;

        public override Task<QueryData<TModel>> QueryAsync(QueryPageOptions option)
        {

            var context = _dbfactory.CreateDbContext();
            var ret = new QueryData<TModel>()
            {
                IsSorted = true,
                IsFiltered = true,
                IsSearch = true
            };

            if (option.IsPage)
            {
                var items = context.Set<TModel>().AsNoTracking()
                                   .Where(option.Filters.GetFilterLambda<TModel>(), option.Filters.Any())
                                   .Sort(option.SortName!, option.SortOrder, !string.IsNullOrEmpty(option.SortName))
                                   .Count(out var count)
                                   .Page((option.PageIndex - 1) * option.PageItems, option.PageItems);

                ret.TotalCount = count;
                ret.Items = items;
            }
            else
            {
                var items = context.Set<TModel>().AsNoTracking()
                                   .Where(option.Filters.GetFilterLambda<TModel>(), option.Filters.Any())
                                   .Sort(option.SortName!, option.SortOrder, !string.IsNullOrEmpty(option.SortName))
                                   .Count(out var count);
                ret.TotalCount = count;
                ret.Items = items;
            }
            return Task.FromResult(ret);

        }

        public override async Task<bool> DeleteAsync(IEnumerable<TModel> models)
        {

            var context = _dbfactory.CreateDbContext();
            context.RemoveRange(models);
            return await context.SaveChangesAsync() > 0;

        }

        public override async Task<bool> SaveAsync(TModel model, ItemChangedType changedType)
        {
            var context = _dbfactory.CreateDbContext();
            if (changedType == ItemChangedType.Add)
            {
                context.Entry(model).State = EntityState.Added;
            }
            else
            {
                context.Entry(model).State = EntityState.Modified;
            }
            return await context.SaveChangesAsync() > 0;
        }

    }
}
