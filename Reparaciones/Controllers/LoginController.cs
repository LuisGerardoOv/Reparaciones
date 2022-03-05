using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reparaciones.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
        {
            return Json("datos");
        }
    }
}
