using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace AbpTestPlus.Web.Views
{
    public abstract class AbpTestPlusRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AbpTestPlusRazorPage()
        {
            LocalizationSourceName = AbpTestPlusConsts.LocalizationSourceName;
        }
    }
}
