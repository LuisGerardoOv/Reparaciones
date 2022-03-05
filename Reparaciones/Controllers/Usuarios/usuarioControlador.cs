using Reparaciones.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Reparaciones.Controllers._ctx;

namespace Reparaciones.Controllers.Usuarios
{
    public class UsuarioControlador : entityConnection
    {
        Dictionary<string, object> result = new Dictionary<string, object>();
        
        public tbl_Empleados login(string correo, string contrasena)
        {
            try
            {
                tbl_Empleados empleado = context.tbl_Empleados.Where(x => x.correo == correo && x.contrasena == contrasena && x.esActivo).FirstOrDefault();
                return empleado;
            }
            catch (Exception o_O)
            {                                
                return null;
            }
        }
    }
}