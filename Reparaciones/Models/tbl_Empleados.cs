using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Reparaciones.Models
{
    public class tbl_Empleados
    {
        [Key]
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidoP { get; set; }
        public string apellidoM { get; set; }
        public string colonia { get; set; }
        public string calle { get; set; }
        public int numeroCasa { get; set; }
        public int telefono { get; set; }
        //0.- Administrador
        //1.- Empleado
        public bool Rol { get; set; }
        //0.- Desempleado
        //1.-Empleado
        public string correo { get; set; }
        public string contrasena { get; set; }
        public bool esActivo { get; set; }
        public tbl_Ventas venta { get; set; }

    }
}