using Abp.Authorization;
using HomeMvc.Authorization.Roles;
using HomeMvc.Authorization.Users;

namespace HomeMvc.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
