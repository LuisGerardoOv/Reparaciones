using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Reparaciones.Models
{
    public class tbl_Clientes
    {
        [Key]
        public int id { get; set; }
        public int idCelular { get; set; }        
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public int telefono { get; set; }
        public tbl_Celulares celulares { get; set; }
        public tbl_Ventas venta { get; set; }

    }
}