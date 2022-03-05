using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Reparaciones.Models
{
    public class tbl_Ventas
    {
        [Key]
        public int id { get; set; }
        public int idCliente { get; set; }        
        public int idCelular { get; set; }
   
        public int idEmpleado { get; set; }

        public DateTime fecha { get; set; }
        public double costo { get; set; }
        public tbl_Clientes clientes { get; set; }
        public tbl_Celulares celulares { get; set; }
        public tbl_Empleados empleados { get; set; }

    }
}