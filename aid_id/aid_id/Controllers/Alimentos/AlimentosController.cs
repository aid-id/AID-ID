using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using aid_id.Models;

namespace aid_id.Controllers.Alimentos
{
    public class AlimentosController : Controller
    {
        private Aid_idContext db = new Aid_idContext();

        // GET: Alimentos
        public ActionResult Index()
        {
            return View(db.Alimentos.ToList());
        }

        // GET: Alimentos/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Alimentos alimentos = db.Alimentos.Find(id);
            if (alimentos == null)
            {
                return HttpNotFound();
            }
            return View(alimentos);
        }

        // GET: Alimentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alimentos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_alimento,Nombre,Carbohidratos,Proteinas,Grasas")] Models.Alimentos alimentos)
        {
            if (ModelState.IsValid)
            {
                db.Alimentos.Add(alimentos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(alimentos);
        }

        // GET: Alimentos/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Alimentos alimentos = db.Alimentos.Find(id);
            if (alimentos == null)
            {
                return HttpNotFound();
            }
            return View(alimentos);
        }

        // POST: Alimentos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_alimento,Nombre,Carbohidratos,Proteinas,Grasas")] Models.Alimentos alimentos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alimentos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(alimentos);
        }

        // GET: Alimentos/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Models.Alimentos alimentos = db.Alimentos.Find(id);
            if (alimentos == null)
            {
                return HttpNotFound();
            }
            return View(alimentos);
        }

        // POST: Alimentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            Models.Alimentos alimentos = db.Alimentos.Find(id);
            db.Alimentos.Remove(alimentos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
