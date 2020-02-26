using System.Collections.Generic;
using AbpTestPlus.Roles.Dto;

namespace AbpTestPlus.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}