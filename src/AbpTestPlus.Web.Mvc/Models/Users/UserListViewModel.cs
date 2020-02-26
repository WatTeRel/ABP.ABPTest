using System.Collections.Generic;
using AbpTestPlus.Roles.Dto;
using AbpTestPlus.Users.Dto;

namespace AbpTestPlus.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
