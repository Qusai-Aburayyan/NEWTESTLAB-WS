using Core.Entites.ApplicationUser;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class DummyData
    {
        public static async Task Initialize(AppDataContext context,
                                            UserManager<ApplicationUser> userManager)
        {
            context.Database.EnsureCreated();

            string password = "NEWTEST@Lab2021";

            if (await userManager.FindByNameAsync("aburayyan.qusai@newtestlab.com") == null)
            {
                var user = new ApplicationUser
                {
                    Email = "aburayyan.qusai@newtestlab.com",
                    UserName = "aburayyan.qusai@newtestlab.com",
                };

                var result = await userManager.CreateAsync(user);

                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, password);
                }
            }

        }

    }
}
