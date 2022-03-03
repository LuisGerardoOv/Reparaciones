using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reparaciones.Models
{
    public class tbl_Ventas
    {
        public int id { get; set; }
        public int idCliente { get; set; }
        [ForeignKey("idCliente")]
        public virtual tbl_Clientes lstClientes { get; set; }
        public int idCelular { get; set; }
        [ForeignKey("idCelular")]
        public virtual tbl_Celulares lstCelulares { get; set; }
        public int idEmpleado { get; set; }
        [ForeignKey("idEmpleado")]
        public virtual tbl_Empleados lstEmpleados { get; set; }
        public DateTime fecha { get; set; }
        public double costo { get; set; }

    }
}