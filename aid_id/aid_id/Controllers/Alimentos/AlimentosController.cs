using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
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

        private string Filter = null;

        // GET: Alimentos
        /// <summary>
        /// Recoge de la BD la lista de alimentos.
        /// </summary>
        /// <param name="filter">Filtra por orden alfabético los alimentos que muestra
        /// según contengan el texto indicado.</param>
        /// <param name="pag">Le indicas en qué página estás de la tabla.</param>
        /// <returns>Una tabla de alimentos con 10 resultados paginados.</returns>
        public ActionResult Index(string filter, int pag)
        {
            if (filter == null)
            {
                filter = Filter;
            }
            else
            {
                Filter = filter;
            }

            if (pag < 1)
            {
                pag = 1;
            }
            // Calcular el total de botones de paginación 
            int pageCount = db.Alimentos.Count();
            double totalPages = pageCount / 10;
            double pageUpRound = Math.Ceiling(totalPages);

            string query = "SELECT * FROM Alimentos";
            var allAlimentos = db.Alimentos.SqlQuery(query).ToList();

            int endCount = 10 * pag;
            int initCount = endCount - 10;
            List<Models.Alimentos> tempAlimentos = new List<Models.Alimentos>();

            for (int i = initCount; i < endCount; i++)
            {
                tempAlimentos.Add(allAlimentos[i]);
            }

            if (filter == null || filter.Equals(""))
            {
                return View(tempAlimentos);
            }

            query += " WHERE nombre LIKE '%" + filter + "%'";
            return View(allAlimentos);
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
