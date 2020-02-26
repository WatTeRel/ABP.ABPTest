using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AbpTestPlus.MultiTenancy.Dto;

namespace AbpTestPlus.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

