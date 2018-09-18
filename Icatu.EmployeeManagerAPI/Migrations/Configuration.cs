namespace Icatu.EmployeeManagerAPI.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Icatu.EmployeeManagerAPI.Models.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Icatu.EmployeeManagerAPI.Models.Context";
        }

        protected override void Seed(Icatu.EmployeeManagerAPI.Models.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
