using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Reparaciones.Models
{
    public class tbl_Marcas
    {
        [Key]        
        public int id { get; set; }
        public string marca { get; set; }
        public tbl_Celulares celulares { get; set; }
    }
}