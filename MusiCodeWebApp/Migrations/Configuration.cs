namespace MusiCodeWebApp.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MusiCodeWebApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DBModel>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DBModel context)
        {
            #region Managers

            //YÖNETİCİLER

            //context.Managers.AddOrUpdate(x => x.ID, new Manager() { ID = 1, Name = "Developer", Surname = "Developer", Mail = "dev@dev.com", ManagerRole_ID = 1, Password = "123456", IsActive = true, IsDeleted = false });

            #endregion

            #region Manager Roles (Types)

            //YÖNETİCİ ROLLERİ (TÜRLERİ)

            //context.ManagerRoles.AddOrUpdate(x => x.ID, new ManagerRole() { ID = 1, RoleName = "Admin", IsDeleted = false });
            //context.ManagerRoles.AddOrUpdate(x => x.ID, new ManagerRole() { ID = 2, RoleName = "Moderatör", IsDeleted = false });

            #endregion
        }
    }
}
