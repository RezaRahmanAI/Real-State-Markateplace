using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Real_Estate.server.api.Helpers;
using Real_Estate.server.api.Models;

namespace Real_Estate.server.api.Data
{
    public class DbInitializer : IDbInitializer
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<ApplicationRole> roleManager;

        public DbInitializer(ApplicationDbContext context, UserManager<ApplicationUser> userManager,
          RoleManager<ApplicationRole> roleManager)
        {
            this.context = context;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        public async Task InitializeDB()
        {

            try
            {
                await context.Database.MigrateAsync();
            }
            catch (Exception ex) { }

        }

        public async Task InitializeRoles()
        {
            if (await roleManager.FindByNameAsync(ApplicationRoles.ROLE_SUPERADMIN) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(ApplicationRoles.ROLE_SUPERADMIN));
            }

            
            if (await roleManager.FindByNameAsync(ApplicationRoles.ROLE_ADMIN) == null)
            {
                await roleManager.CreateAsync(new ApplicationRole(ApplicationRoles.ROLE_ADMIN));
            }
        }

        public async Task InitializeUsers()
        {
            if (await userManager.FindByEmailAsync("sysadmin@realestate.com") == null)
            {
                ApplicationUser applicationUser = new ApplicationUser();
                applicationUser.Email = "sysadmin@realestate.com";
                applicationUser.FullName = "Super Admin";
                applicationUser.UserName = "sysadmin@realestate.com";
                applicationUser.PhoneNumber = null;
                applicationUser.RegistrationDate = DateTime.UtcNow;
                applicationUser.Picture = "default_picture.png";
                applicationUser.IsBlocked = false;
                applicationUser.EmailConfirmed = true;


                var result = await userManager.CreateAsync(applicationUser);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(applicationUser, "Hello@123");
                    await userManager.AddToRoleAsync(applicationUser, ApplicationRoles.ROLE_SUPERADMIN);
                }
            }

        }

        //public async Task SeedProjects()
        //{
        //    if(!await context.Projects.AnyAsync())
        //    {
        //        var projects = new List<Project>
        //        {
        //            new Project
        //            {
        //                Id = Guid.CreateVersion7().ToString(),
        //                Name = "Project 1",
        //                CreateDate = DateTime.UtcNow,
        //                Description = "this is project 1",
        //                IsActive = true
        //            },
        //            new Project
        //            {
        //                Id = Guid.CreateVersion7().ToString(),
        //                Name = "Project 2",
        //                CreateDate = DateTime.UtcNow,
        //                Description = "this is project 2",
        //                IsActive = true
        //            },
        //            new Project
        //            {
        //                Id = Guid.CreateVersion7().ToString(),
        //                Name = "Project 3",
        //                CreateDate = DateTime.UtcNow,
        //                Description = "this is project 3",
        //                IsActive = true
        //            }

        //        };
        //        await context.Projects.AddRangeAsync(projects);
        //        await context.SaveChangesAsync();

        //    }
        //}
    }

    public interface IDbInitializer
    {
        Task InitializeDB();
        Task InitializeRoles();
        Task InitializeUsers();
        //Task SeedProjects();
    }
}