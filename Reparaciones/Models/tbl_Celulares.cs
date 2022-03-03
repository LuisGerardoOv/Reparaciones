using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;


namespace Reparaciones.Models
{
    public class tbl_Celulares
    {
        public int id { get; set; }
        public int idMarca { get; set; }
        [ForeignKey("idMarca")]
        public virtual tbl_Marcas lstMarcas { get; set; }
        public string modelo { get; set; }
        public string caracteristicas { get; set; }

    }
}