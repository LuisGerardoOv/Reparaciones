using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Reparaciones.Models
{
    public class tbl_Celulares
    {       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }  
        public int idMarca { get; set; }
        [ForeignKey("idMarca")]
        public virtual tbl_Marcas lstMarca { get; set; }
        public string modelo { get; set; }
        public string caracteristicas { get; set; }
        public bool esReparado { get; set; }

    }
}