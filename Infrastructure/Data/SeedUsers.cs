using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public static class SeedUsers
    {
        public static void SeedUser(UserManager<IdentityUser> userManager)
        {
            if(userManager.FindByEmailAsync("info@newtestlab.com").Result==null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "info@newtestlab.com",
                    Email = "info@newtestlab.com",
                };
                IdentityResult result = userManager.CreateAsync(user, "NEWTEST@Lab21").Result;
                if(result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
        }
    }
}
