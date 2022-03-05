using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reparaciones.DTO
{
    public class celularesDTO
    {
        public int id { get; set; }
        public int idMarca { get; set; }    
        public string marca { get; set; }
        public string modelo { get; set; }
        
        public string caracteristicas { get; set; }
        public bool esReparado { get; set; }
        public string esreparado { get; set; }
    }
}