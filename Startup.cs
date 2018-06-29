using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebSiteAboutMe.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

[assembly: OwinStartupAttribute(typeof(WebSiteAboutMe.Startup))]
namespace WebSiteAboutMe
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
        }

        private void CreateRolesAndUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            if (!roleManager.RoleExists("Admin"))
            {
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                var user = new ApplicationUser();
                user.Email = "oskarprzybylski@nordlearn.pl";
                user.UserName = "oskarprzybylski@nordlearn.pl";
                user.EmailConfirmed = true;
                var chkuser = userManager.Create(user, "1zbmwer01");

                var user2 = new ApplicationUser();
                user2.Email = "mateusz.szczesny@nordlearn.pl";
                user2.UserName = "mateusz.szczesny@nordlearn.pl";
                user2.EmailConfirmed = true;
               var chkuser2 =  userManager.Create(user2, "1zbmwer01");
                if (chkuser.Succeeded)
                {
                    userManager.AddToRole(user.Id, "Admin");

                }
                if (chkuser2.Succeeded)
                {
                    userManager.AddToRole(user2.Id, "Admin");
                }

            }
            if (!roleManager.RoleExists("Moderator"))
            {
                var role = new IdentityRole();
                role.Name = "Moderator";
                roleManager.Create(role);
            }
            if (!roleManager.RoleExists("DefaultUser"))
            {
                var role = new IdentityRole();
                role.Name = "DefaultUser";
                roleManager.Create(role);
            }
        }
    }
}