using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
using Reparaciones.Controllers.Celulares;
using Reparaciones.Controllers.Usuarios;
using Reparaciones.DTO;
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

        public ActionResult celulares()
        {
            return View();
        }       

        public JsonResult Login(string correo, string contrasena)
        {
            UsuarioControlador usuarios = new UsuarioControlador();
            tbl_Empleados obj = usuarios.login(correo, contrasena);          
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

 
      
        public JsonResult GetCelulares()
        {            
            celularControlador celular = new celularControlador();
            List<celularesDTO> obj = celular.GetCelulares();
            return Json(obj, JsonRequestBehavior.AllowGet);

        }
    }
}