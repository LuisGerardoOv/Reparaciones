﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Reparaciones.Models
{
    public class tbl_Empleados
    {
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
        public bool esActivo { get; set; }
    }
}