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
    public class ZonasController : Controller
    {
        private CampDiosEntities db = new CampDiosEntities();

        // GET: Zonas
        public ActionResult Index()
        {
            var zonas = db.Zonas.Include(z => z.Miembro);
            return View(zonas.ToList());
        }

        // GET: Zonas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zona zona = db.Zonas.Find(id);
            if (zona == null)
            {
                return HttpNotFound();
            }
            return View(zona);
        }

        // GET: Zonas/Create
        public ActionResult Create()
        {
            ViewBag.IdLiderZona = new SelectList(db.Miembros, "IdMiembro", "Nombres");
            return View();
        }

        // POST: Zonas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdZona,Nombre,Descripcion,Direccion,IdLiderZona")] Zona zona)
        {
            if (ModelState.IsValid)
            {
                db.Zonas.Add(zona);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdLiderZona = new SelectList(db.Miembros, "IdMiembro", "Nombres", zona.IdLiderZona);
            return View(zona);
        }

        // GET: Zonas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zona zona = db.Zonas.Find(id);
            if (zona == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdLiderZona = new SelectList(db.Miembros, "IdMiembro", "Nombres", zona.IdLiderZona);
            return View(zona);
        }

        // POST: Zonas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdZona,Nombre,Descripcion,Direccion,IdLiderZona")] Zona zona)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zona).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdLiderZona = new SelectList(db.Miembros, "IdMiembro", "Nombres", zona.IdLiderZona);
            return View(zona);
        }

        // GET: Zonas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zona zona = db.Zonas.Find(id);
            if (zona == null)
            {
                return HttpNotFound();
            }
            return View(zona);
        }

        // POST: Zonas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Zona zona = db.Zonas.Find(id);
            db.Zonas.Remove(zona);
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
