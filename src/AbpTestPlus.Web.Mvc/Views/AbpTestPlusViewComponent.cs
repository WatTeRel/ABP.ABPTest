using Abp.AspNetCore.Mvc.ViewComponents;

namespace AbpTestPlus.Web.Views
{
    public abstract class AbpTestPlusViewComponent : AbpViewComponent
    {
        protected AbpTestPlusViewComponent()
        {
            LocalizationSourceName = AbpTestPlusConsts.LocalizationSourceName;
        }
    }
}
