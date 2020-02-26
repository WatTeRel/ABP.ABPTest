using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpTestPlus.Configuration;

namespace AbpTestPlus.Web.Host.Startup
{
    [DependsOn(
       typeof(AbpTestPlusWebCoreModule))]
    public class AbpTestPlusWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AbpTestPlusWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpTestPlusWebHostModule).GetAssembly());
        }
    }
}
