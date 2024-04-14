using FlyManager01.Models;
using Microsoft.AspNetCore.Identity;

namespace FlyManager01.Data
{
    public static class DBRoles
    {
        public static async Task SeedRoleAndAdmin(IServiceProvider service)
        {
            UserManager<AccountsUser> userManager = (UserManager<AccountsUser>)service.GetServices<UserManager<AccountsUser>>();
            RoleManager<IdentityRole> roleManager = (RoleManager<IdentityRole>)service.GetServices<RoleManager<IdentityRole>>();
           // await roleManager.CreateAsync(new IdentityRole(Models.Works));
            await roleManager.CreateAsync(new IdentityRole());
        }
        
    }
}
