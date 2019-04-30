using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using aid_id.Models;
using System.Data.SqlClient;

namespace aid_id.Controllers
{
    public class AverageController : Controller
    {
        private Aid_idContext db = new Aid_idContext();

        // GET: Average
        public ActionResult Index()
        {
            string value = "";
            var cookieLogin = ControllerContext.HttpContext.Request.Cookies["cookieLogin"];
            if (cookieLogin != null)
            {
                value = cookieLogin.Value;
            }
            string value2 = "";
            var cookieEmail = ControllerContext.HttpContext.Request.Cookies["cookieEmail"];
            if (cookieEmail != null)
            {
                value2 = cookieEmail.Value;
            }
            if (value == "1" && value2 == cookieEmail.Value)
            {
                var analisis = db.Analisis.Include(a => a.Usuarios);
                return View(analisis.ToList());
            }
            else
            {
                return RedirectToAction("Index", "Login");
            }
            
        }
    }
}