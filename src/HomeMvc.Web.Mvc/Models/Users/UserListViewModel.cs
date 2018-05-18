using System.Collections.Generic;
using HomeMvc.Roles.Dto;
using HomeMvc.Users.Dto;

namespace HomeMvc.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
