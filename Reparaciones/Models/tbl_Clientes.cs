using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reparaciones.Models
{
    public class tbl_Clientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public int telefono { get; set; }
        public int idCelular { get; set; }
        [ForeignKey("idCelular")]
        public virtual tbl_Celulares lstCelulares { get; set; }
    }
}