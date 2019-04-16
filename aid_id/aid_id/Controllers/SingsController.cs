using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace aid_id.Controllers
{
    public class SingsController : Controller
    {
        // GET: Sings
        public ActionResult Index()
        {
            return View();
        }

        // GET: SingIn
        public ActionResult SingIn()
        {
            return View();

        }

        // GET: SingUp
        public ActionResult SingUp()
        {
            return View();

        }
    }
}