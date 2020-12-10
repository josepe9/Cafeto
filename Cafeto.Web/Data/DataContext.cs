using Cafeto.Common.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
