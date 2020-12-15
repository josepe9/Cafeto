using Cafeto.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cafeto.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Corregimiento> Corregimiento { get; set; }
        public DbSet<Vereda> Veredas { get; set; }
        public DbSet<Finca> Fincas { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<Hectarea> Hectareas { get; set; }
        public DbSet<Parafertil> Parafertils { get; set; }
        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Departamento>()
                .HasIndex(t => t.Codigo)
                .IsUnique();

            modelBuilder.Entity<Ciudad>()
                .HasIndex(t => t.Codigo)
                .IsUnique();
        }
    }
}
