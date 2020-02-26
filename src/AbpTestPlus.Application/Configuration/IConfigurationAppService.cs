using System.Threading.Tasks;
using AbpTestPlus.Configuration.Dto;

namespace AbpTestPlus.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
