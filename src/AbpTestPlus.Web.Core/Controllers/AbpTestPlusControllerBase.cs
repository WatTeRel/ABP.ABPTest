using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AbpTestPlus.Controllers
{
    public abstract class AbpTestPlusControllerBase: AbpController
    {
        protected AbpTestPlusControllerBase()
        {
            LocalizationSourceName = AbpTestPlusConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
