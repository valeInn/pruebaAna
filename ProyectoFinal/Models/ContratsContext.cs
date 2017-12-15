using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProyectoFinal.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProyectoFinal.Models
{
    public class ContratsContext : DbContext
    {
        public  ContratsContext() :  base("ContratsContext")
        {
        }
        public DbSet<Contratos> Contratos { get; set; }
        public DbSet<Propiedades> Propiedades { get; set; }
        public DbSet<Locatario> Locatarios { get; set; }
        public DbSet<Locador> Locadores { get; set; }
        public DbSet<Garante> Garantes { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
    


   