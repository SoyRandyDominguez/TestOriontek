using Abp.Authorization;
using TestOriontec.Authorization.Roles;
using TestOriontec.Authorization.Users;

namespace TestOriontec.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
