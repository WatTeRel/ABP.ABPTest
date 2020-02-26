using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using AbpTestPlus.Configuration;
using AbpTestPlus.Web;

namespace AbpTestPlus.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AbpTestPlusDbContextFactory : IDesignTimeDbContextFactory<AbpTestPlusDbContext>
    {
        public AbpTestPlusDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AbpTestPlusDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AbpTestPlusDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AbpTestPlusConsts.ConnectionStringName));

            return new AbpTestPlusDbContext(builder.Options);
        }
    }
}
