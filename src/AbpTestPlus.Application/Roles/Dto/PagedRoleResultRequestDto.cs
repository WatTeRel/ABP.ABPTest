using Abp.Application.Services.Dto;

namespace AbpTestPlus.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

