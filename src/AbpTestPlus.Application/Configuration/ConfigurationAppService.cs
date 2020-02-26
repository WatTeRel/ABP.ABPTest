using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AbpTestPlus.Configuration.Dto;

namespace AbpTestPlus.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AbpTestPlusAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
