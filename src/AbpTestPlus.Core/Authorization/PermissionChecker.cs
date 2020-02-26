using Abp.Authorization;
using AbpTestPlus.Authorization.Roles;
using AbpTestPlus.Authorization.Users;

namespace AbpTestPlus.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
