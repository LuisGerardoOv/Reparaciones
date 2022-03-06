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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int clienteid { get; set; }
        [ForeignKey("clienteid")]
        public virtual tbl_Clientes lstCliente { get; set; }
        public int celularid { get; set; }        
        public virtual tbl_Celulares lstCelular { get; set; }
        public int empleadoid { get; set; }
        //[ForeignKey("empleadoid")]
        //public virtual tbl_Empleados lstEmpleado { get; set; }
        public DateTime fecha { get; set; }
        public double costo { get; set; }


    }
}