using PlazaVeaCRMWeb.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PlazaVeaCRMWeb.DAL
{
    public class PlazaVeaCrmContext : DbContext
    {
        public PlazaVeaCrmContext() : base("PlazaVeaCrmContextConn")
        {
        }

        public DbSet<Banco> Banco { get; set; }
        public DbSet<CuentaBancaria> CuentaBancaria { get; set; }
        public DbSet<CuentaBanco> CuentaBanco { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
