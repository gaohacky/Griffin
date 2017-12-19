using Abp.Authorization;
using Griffin.Authorization.Roles;
using Griffin.Authorization.Users;

namespace Griffin.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
