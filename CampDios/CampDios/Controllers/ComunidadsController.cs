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
    public class ComunidadsController : Controller
    {
        private CampDiosEntities db = new CampDiosEntities();

        // GET: Comunidads
        public ActionResult Index()
        {
            var comunidads = db.Comunidads.Include(c => c.Miembro).Include(c => c.Zona);
            return View(comunidads.ToList());
        }

        // GET: Comunidads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comunidad comunidad = db.Comunidads.Find(id);
            if (comunidad == null)
            {
                return HttpNotFound();
            }
            return View(comunidad);
        }

        // GET: Comunidads/Create
        public ActionResult Create()
        {
            ViewBag.IdLiderComunidad = new SelectList(db.Miembros, "IdMiembro", "Nombres");
            ViewBag.IdZona = new SelectList(db.Zonas, "IdZona", "Nombre");
            return View();
        }

        // POST: Comunidads/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdComunidad,Nombre,Descripcion,Direccion,IdLiderComunidad,IdZona")] Comunidad comunidad)
        {
            if (ModelState.IsValid)
            {
                db.Comunidads.Add(comunidad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdLiderComunidad = new SelectList(db.Miembros, "IdMiembro", "Nombres", comunidad.IdLiderComunidad);
            ViewBag.IdZona = new SelectList(db.Zonas, "IdZona", "Nombre", comunidad.IdZona);
            return View(comunidad);
        }

        // GET: Comunidads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comunidad comunidad = db.Comunidads.Find(id);
            if (comunidad == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdLiderComunidad = new SelectList(db.Miembros, "IdMiembro", "Nombres", comunidad.IdLiderComunidad);
            ViewBag.IdZona = new SelectList(db.Zonas, "IdZona", "Nombre", comunidad.IdZona);
            return View(comunidad);
        }

        // POST: Comunidads/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdComunidad,Nombre,Descripcion,Direccion,IdLiderComunidad,IdZona")] Comunidad comunidad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comunidad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdLiderComunidad = new SelectList(db.Miembros, "IdMiembro", "Nombres", comunidad.IdLiderComunidad);
            ViewBag.IdZona = new SelectList(db.Zonas, "IdZona", "Nombre", comunidad.IdZona);
            return View(comunidad);
        }

        // GET: Comunidads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comunidad comunidad = db.Comunidads.Find(id);
            if (comunidad == null)
            {
                return HttpNotFound();
            }
            return View(comunidad);
        }

        // POST: Comunidads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Comunidad comunidad = db.Comunidads.Find(id);
            db.Comunidads.Remove(comunidad);
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
