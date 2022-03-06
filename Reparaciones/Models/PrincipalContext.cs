using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reparaciones.Models
{
    public class PrincipalContext : DbContext
    {
        public PrincipalContext() : base("DbConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<tbl_Celulares>().HasRequired(x => x.lstMarca);
            modelBuilder.Entity<tbl_Clientes>().HasRequired(x => x.lstCelulares);
            modelBuilder.Entity<tbl_Ventas>().HasRequired(x => x.lstCliente);
            modelBuilder.Entity<tbl_Ventas>().HasRequired(x => x.lstCelular).WithRequired().HasForeignKey(z=>z.celularid);





        }

        //TABLAS
        public DbSet<tbl_Celulares> tbl_Celulares { get; set; }
        public DbSet<tbl_Clientes> tbl_Clientes { get; set; }
        public DbSet<tbl_Empleados> tbl_Empleados { get; set; }
        public DbSet<tbl_Marcas> tbl_Marcas { get; set; }
        public DbSet<tbl_Ventas> tbl_Ventas { get; set; }
    }
}