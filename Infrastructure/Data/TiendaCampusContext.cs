using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Data
{
    public class TiendaCampusContext : DbContext
    {
        public TiendaCampusContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pais> Paises {get; set;}
        public DbSet<Departamento> Departamentos {get; set;}
        public DbSet<Ciudad> Ciudades {get; set;}
        protected  override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}