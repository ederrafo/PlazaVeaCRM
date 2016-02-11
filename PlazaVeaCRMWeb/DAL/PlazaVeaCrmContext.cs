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

        public virtual DbSet<DetalleOrdenDespacho> DetalleOrdenDespacho { get; set; }
        public virtual DbSet<DetalleSolicitudCompra> DetalleSolicitudCompra { get; set; }
        public virtual DbSet<OrdenDespacho> OrdenDespacho { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<PersonalProgramado> PersonalProgramado { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<RutaOrdenDespacho> RutaOrdenDespacho { get; set; }
        public virtual DbSet<SolicitudCompra> SolicitudCompra { get; set; }
        public virtual DbSet<Transporte> Transporte { get; set; }
        public virtual DbSet<Turno> Turno { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            #region Builders Modulo Distribución
            
            modelBuilder.Entity<DetalleOrdenDespacho>()
                .Property(e => e.CantidadRequerida)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DetalleSolicitudCompra>()
                .Property(e => e.CantidadSolicitada)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrdenDespacho>()
                .HasMany(e => e.RutaOrdenDespacho)
                .WithRequired(e => e.OrdenDespacho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrdenDespacho>()
                .HasMany(e => e.SolicitudCompra)
                .WithRequired(e => e.OrdenDespacho)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Persona>()
                .HasMany(e => e.PersonalProgramado)
                .WithRequired(e => e.Persona)
                .WillCascadeOnDelete(false);
            
            //modelBuilder.Entity<PersonalProgramado>()
            //    .HasMany(e => e.OrdenDespacho)
            //    .WithOptional(e => e.PersonalProgramado)
            //    .HasForeignKey(e => e.IdConductor);

            modelBuilder.Entity<PersonalProgramado>() // Revisar
                .HasMany(e => e.OrdenDespacho)
                .WithOptional(e => e.PersonalProgramado)
                .HasForeignKey(e => e.IdOperario);

            modelBuilder.Entity<Transporte>()
                .HasMany(e => e.OrdenDespacho)
                .WithRequired(e => e.Transporte)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Turno>()
                .HasMany(e => e.PersonalProgramado)
                .WithRequired(e => e.Turno)
                .WillCascadeOnDelete(false);

            #endregion
        }

    }
}
