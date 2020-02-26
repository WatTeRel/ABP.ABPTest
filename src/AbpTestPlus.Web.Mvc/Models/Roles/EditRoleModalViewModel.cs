using Abp.AutoMapper;
using AbpTestPlus.Roles.Dto;
using AbpTestPlus.Web.Models.Common;

namespace AbpTestPlus.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
