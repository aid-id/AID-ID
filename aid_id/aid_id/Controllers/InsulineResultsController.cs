using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using aid_id.Models;

namespace aid_id.Controllers
{
    public class InsulineResultsController : Controller
    {
   
        // GET: InsulineResults
        public ActionResult InsulineResults()
        {
            return View();
        } 
    }
}
