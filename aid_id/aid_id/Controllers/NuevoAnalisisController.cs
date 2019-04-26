using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using aid_id.Data;

namespace aid_id.Controllers
{
    public class NuevoAnalisisController : Controller
    {
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
        public ActionResult Create([Bind(Include = "Id_analisis,Valor,TipoComida,Carbo_totales,Id_usuario")] Models.Analisis analisis)
        {
            if (ModelState.IsValid)
            {
                db.Alimentos.Add(analisis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(analisis);
        }
    }
}