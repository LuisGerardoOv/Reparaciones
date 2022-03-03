using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


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
            modelBuilder.Entity<tbl_Ventas>().HasKey(x => x.idCelular);
            modelBuilder.Entity<tbl_Ventas>().HasKey(x => x.idCliente);
            modelBuilder.Entity<tbl_Ventas>().HasKey(x => x.idEmpleado);
            modelBuilder.Entity<tbl_Celulares>().HasKey(x => x.idMarca);
            modelBuilder.Entity<tbl_Clientes>().HasKey(x => x.idCelular);
        }

        //TABLAS
        public DbSet<tbl_Celulares> tbl_Celulares { get; set; }
        public DbSet<tbl_Clientes> tbl_Clientes { get; set; }
        public DbSet<tbl_Empleados> tbl_Empleados { get; set; }
        public DbSet<tbl_Marcas> tbl_Marcas { get; set; }
        public DbSet<tbl_Ventas> tbl_Ventas { get; set; }
    }
}