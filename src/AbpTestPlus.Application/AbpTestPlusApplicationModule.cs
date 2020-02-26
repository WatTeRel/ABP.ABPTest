using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AbpTestPlus.Authorization;

namespace AbpTestPlus
{
    [DependsOn(
        typeof(AbpTestPlusCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AbpTestPlusApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AbpTestPlusAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AbpTestPlusApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
