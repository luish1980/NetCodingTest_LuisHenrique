using System.Data.Entity;
using MySql.Data.Entity;

namespace Icatu.EmployeeManagerAPI.Models
{
    
    public class Context:DbContext
    {
        public Context() : base("Context")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Icatu.EmployeeManagerAPI.Migrations.Configuration>());
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}