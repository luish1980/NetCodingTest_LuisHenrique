using System.Data.Entity;
using Icatu.EmployeeManagerAPI.Entidade;
using MySql.Data.Entity;

namespace Icatu.EmployeeManagerAPI.Repositorio
{
    public class Context:DbContext
    {
        public Context() : base("Context")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Icatu.EmployeeManagerAPI.Repositorio.Migrations.Configuration>());
        }


        public virtual DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}