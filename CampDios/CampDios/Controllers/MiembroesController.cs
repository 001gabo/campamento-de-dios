using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CampDios;

namespace CampDios.Controllers
{
    public class MiembroesController : Controller
    {
        private CampDiosEntities db = new CampDiosEntities();

        // GET: Miembroes
        public ActionResult Index()
        {
            var miembros = db.Miembros.Include(m => m.Capacitacione).Include(m => m.LiderasgoCorporativo).Include(m => m.LiderasgoPastoral).Include(m => m.Profesion);
            return View(miembros.ToList());
        }

        // GET: Miembroes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Miembro miembro = db.Miembros.Find(id);
            if (miembro == null)
            {
                return HttpNotFound();
            }
            return View(miembro);
        }

        // GET: Miembroes/Create
        public ActionResult Create()
        {
            ViewBag.IdCapacitacion = new SelectList(db.Capacitaciones, "IdCapacitacion", "Nombre");
            ViewBag.IdCorporativo = new SelectList(db.LiderasgoCorporativoes, "IdCorporativo", "Nombre");
            ViewBag.IdPastoreo = new SelectList(db.LiderasgoPastorals, "IdPastoreo", "Nombre");
            ViewBag.IdProfesion = new SelectList(db.Profesions, "IdProfesion", "Descripcion");
            return View();
        }

        // POST: Miembroes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMiembro,Nombres,Apellidos,DUI,NIT,FechaNacimiento,Direccion,Direccion1,Direccion2,Email,Tel,Cel,Sexo,EstadoCivil,IdProfesion,IdCapacitacion,IdPastoreo,IdCorporativo")] Miembro miembro)
        {
            if (ModelState.IsValid)
            {
                db.Miembros.Add(miembro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCapacitacion = new SelectList(db.Capacitaciones, "IdCapacitacion", "Nombre", miembro.IdCapacitacion);
            ViewBag.IdCorporativo = new SelectList(db.LiderasgoCorporativoes, "IdCorporativo", "Nombre", miembro.IdCorporativo);
            ViewBag.IdPastoreo = new SelectList(db.LiderasgoPastorals, "IdPastoreo", "Nombre", miembro.IdPastoreo);
            ViewBag.IdProfesion = new SelectList(db.Profesions, "IdProfesion", "Descripcion", miembro.IdProfesion);
            return View(miembro);
        }

        // GET: Miembroes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Miembro miembro = db.Miembros.Find(id);
            if (miembro == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCapacitacion = new SelectList(db.Capacitaciones, "IdCapacitacion", "Nombre", miembro.IdCapacitacion);
            ViewBag.IdCorporativo = new SelectList(db.LiderasgoCorporativoes, "IdCorporativo", "Nombre", miembro.IdCorporativo);
            ViewBag.IdPastoreo = new SelectList(db.LiderasgoPastorals, "IdPastoreo", "Nombre", miembro.IdPastoreo);
            ViewBag.IdProfesion = new SelectList(db.Profesions, "IdProfesion", "Descripcion", miembro.IdProfesion);
            return View(miembro);
        }

        // POST: Miembroes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdMiembro,Nombres,Apellidos,DUI,NIT,FechaNacimiento,Direccion,Direccion1,Direccion2,Email,Tel,Cel,Sexo,EstadoCivil,IdProfesion,IdCapacitacion,IdPastoreo,IdCorporativo")] Miembro miembro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(miembro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCapacitacion = new SelectList(db.Capacitaciones, "IdCapacitacion", "Nombre", miembro.IdCapacitacion);
            ViewBag.IdCorporativo = new SelectList(db.LiderasgoCorporativoes, "IdCorporativo", "Nombre", miembro.IdCorporativo);
            ViewBag.IdPastoreo = new SelectList(db.LiderasgoPastorals, "IdPastoreo", "Nombre", miembro.IdPastoreo);
            ViewBag.IdProfesion = new SelectList(db.Profesions, "IdProfesion", "Descripcion", miembro.IdProfesion);
            return View(miembro);
        }

        // GET: Miembroes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Miembro miembro = db.Miembros.Find(id);
            if (miembro == null)
            {
                return HttpNotFound();
            }
            return View(miembro);
        }

        // POST: Miembroes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Miembro miembro = db.Miembros.Find(id);
            db.Miembros.Remove(miembro);
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
