namespace TelekomBem.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TelekomBem.DAL.TelekomContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TelekomBem.DAL.TelekomContext context)
        {
            context.Firmalar.Add(new Model.Firma() { FirmaAdi = "SLN", Adres = "Deneme", Tel = "0533 333 33 33", Email = "ezgi@gmail.com", Vd = "Beylikdüzü", Vn = "123456789" });
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
