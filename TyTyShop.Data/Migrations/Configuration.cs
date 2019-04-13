namespace TyTyShop.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TyTyShop.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TyTyShop.Data.TyTyShopDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TyTyShop.Data.TyTyShopDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new TyTyShopDbContext()));

            var roleManger = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new TyTyShopDbContext()));
            var User = new ApplicationUser()
            {
                UserName = "linhdev",
                Email = "thilylinh98@gmail.com",
                EmailConfirmed = true,
                Birthday = DateTime.Now,
                FullName = "thi ly linh"
            };
            manager.Create(User, "123456");
            if (!roleManger.Roles.Any())
            {
                roleManger.Create(new IdentityRole { Name = "Admin" });
                roleManger.Create(new IdentityRole { Name = "User" });
            }
            var adminUser = manager.FindByEmail("thilylinh98@gmail.com");
            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
    }
}