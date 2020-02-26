using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AbpTestPlus.EntityFrameworkCore
{
    public static class AbpTestPlusDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AbpTestPlusDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AbpTestPlusDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
