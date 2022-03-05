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
        [Key]
        public int id { get; set; }    
        public int idMarca { get; set; }        
        public string modelo { get; set; }
        public string caracteristicas { get; set; }
        public bool esReparado { get; set; }
        public tbl_Clientes clientes { get; set; }
        public tbl_Ventas ventas { get; set; }
        public tbl_Marcas marcas { get; set; }


    }
}