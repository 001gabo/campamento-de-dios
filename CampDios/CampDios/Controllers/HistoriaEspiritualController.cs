using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CampDios.Modelo;

namespace CampDios.Controllers
{
    public class HistoriaEspiritualController : Controller
    {
        private CampDiosEntities db = new CampDiosEntities();

        // GET: HistoriaEspiritual
        public ActionResult Index()
        {
            var historiaEspirituals = db.HistoriaEspirituals.Include(h => h.Miembro);
            return View(historiaEspirituals.ToList());
        }

        // GET: HistoriaEspiritual/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoriaEspiritual historiaEspiritual = db.HistoriaEspirituals.Find(id);
            if (historiaEspiritual == null)
            {
                return HttpNotFound();
            }
            return View(historiaEspiritual);
        }

        // GET: HistoriaEspiritual/Create
        public ActionResult Create()
        {
            ViewBag.IdMiembro = new SelectList(db.Miembros, "IdMiembro", "Nombres");
            return View();
        }

        // POST: HistoriaEspiritual/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdHistoria,IdMiembro,FechaConversion,FechaBautismo,IglesiaBautismo")] HistoriaEspiritual historiaEspiritual)
        {
            if (ModelState.IsValid)
            {
                db.HistoriaEspirituals.Add(historiaEspiritual);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdMiembro = new SelectList(db.Miembros, "IdMiembro", "Nombres", historiaEspiritual.IdMiembro);
            return View(historiaEspiritual);
        }

        // GET: HistoriaEspiritual/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoriaEspiritual historiaEspiritual = db.HistoriaEspirituals.Find(id);
            if (historiaEspiritual == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdMiembro = new SelectList(db.Miembros, "IdMiembro", "Nombres", historiaEspiritual.IdMiembro);
            return View(historiaEspiritual);
        }

        // POST: HistoriaEspiritual/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdHistoria,IdMiembro,FechaConversion,FechaBautismo,IglesiaBautismo")] HistoriaEspiritual historiaEspiritual)
        {
            if (ModelState.IsValid)
            {
                db.Entry(historiaEspiritual).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdMiembro = new SelectList(db.Miembros, "IdMiembro", "Nombres", historiaEspiritual.IdMiembro);
            return View(historiaEspiritual);
        }

        // GET: HistoriaEspiritual/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HistoriaEspiritual historiaEspiritual = db.HistoriaEspirituals.Find(id);
            if (historiaEspiritual == null)
            {
                return HttpNotFound();
            }
            return View(historiaEspiritual);
        }

        // POST: HistoriaEspiritual/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HistoriaEspiritual historiaEspiritual = db.HistoriaEspirituals.Find(id);
            db.HistoriaEspirituals.Remove(historiaEspiritual);
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
