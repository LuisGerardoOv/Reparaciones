using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Reparaciones.Controllers.Usuarios;
using Reparaciones.Models;

namespace Reparaciones.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult inicio()
        {
            return View();
        }

        public JsonResult Login(string correo, string contrasena)
        {
            UsuarioControlador usuarios = new UsuarioControlador();
            tbl_Empleados obj = usuarios.login(correo, contrasena);          
            return Json(obj, JsonRequestBehavior.AllowGet);
        }
    }
}