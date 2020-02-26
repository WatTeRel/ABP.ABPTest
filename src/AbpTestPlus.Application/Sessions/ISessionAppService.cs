using System.Threading.Tasks;
using Abp.Application.Services;
using AbpTestPlus.Sessions.Dto;

namespace AbpTestPlus.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
