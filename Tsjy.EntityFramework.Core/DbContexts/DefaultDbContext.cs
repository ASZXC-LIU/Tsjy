using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace Tsjy.EntityFramework.Core
{
    [AppDbContext("MySqlConnectionString", DbProvider.MySqlOfficial)]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
            //新增忽略空值
            InsertOrUpdateIgnoreNullValues = true;
        }


    }
}
