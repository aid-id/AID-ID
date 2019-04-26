using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aid_id.Data;
using aid_id.Models;

namespace aid_id.Controllers
{
    public class NuevoAnalisisController : Controller
    {
        private Aid_idContext db = new Aid_idContext();

        // GET: NuevoAnalisis
        public ActionResult Index()
        {
            var repo = new AnalisisRepository();
            var alimentosList = repo.CrearAnalisis();
            return View(alimentosList);
        }

        //POST Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "Id_analisis,Valor,TipoComida,Carbo_totales,Id_usuario")] Models.Analisis analisis)
        {
            if (ModelState.IsValid)
            {
                db.Analisis.Add(analisis);
                db.SaveChanges();
                return RedirectToAction("ResultInsulina");
            }

            return View(analisis);
        }

        public ActionResult ResultInsulina()
        {
            return View();
        }
    }
}