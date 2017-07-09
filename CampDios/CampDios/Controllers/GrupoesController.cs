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
    public class GrupoesController : Controller
    {
        private CampDiosEntities db = new CampDiosEntities();

        // GET: Grupoes
        public ActionResult Index()
        {
            var grupoes = db.Grupoes.Include(g => g.Comunidad).Include(g => g.Miembro).Include(g => g.Tipo_Grupo);
            return View(grupoes.ToList());
        }

        // GET: Grupoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grupo grupo = db.Grupoes.Find(id);
            if (grupo == null)
            {
                return HttpNotFound();
            }
            return View(grupo);
        }

        // GET: Grupoes/Create
        public ActionResult Create()
        {
            ViewBag.IdComunidad = new SelectList(db.Comunidads, "IdComunidad", "Nombre");
            ViewBag.IdLiderGrupo = new SelectList(db.Miembros, "IdMiembro", "Nombres");
            ViewBag.IdTipoGrupo = new SelectList(db.Tipo_Grupo, "IdTipoGrupo", "Descripcion");
            return View();
        }

        // POST: Grupoes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdGrupo,Nombre,Descripcion,Direccion,IdLiderGrupo,IdComunidad,IdTipoGrupo")] Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                db.Grupoes.Add(grupo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdComunidad = new SelectList(db.Comunidads, "IdComunidad", "Nombre", grupo.IdComunidad);
            ViewBag.IdLiderGrupo = new SelectList(db.Miembros, "IdMiembro", "Nombres", grupo.IdLiderGrupo);
            ViewBag.IdTipoGrupo = new SelectList(db.Tipo_Grupo, "IdTipoGrupo", "Descripcion", grupo.IdTipoGrupo);
            return View(grupo);
        }

        // GET: Grupoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grupo grupo = db.Grupoes.Find(id);
            if (grupo == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdComunidad = new SelectList(db.Comunidads, "IdComunidad", "Nombre", grupo.IdComunidad);
            ViewBag.IdLiderGrupo = new SelectList(db.Miembros, "IdMiembro", "Nombres", grupo.IdLiderGrupo);
            ViewBag.IdTipoGrupo = new SelectList(db.Tipo_Grupo, "IdTipoGrupo", "Descripcion", grupo.IdTipoGrupo);
            return View(grupo);
        }

        // POST: Grupoes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdGrupo,Nombre,Descripcion,Direccion,IdLiderGrupo,IdComunidad,IdTipoGrupo")] Grupo grupo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(grupo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdComunidad = new SelectList(db.Comunidads, "IdComunidad", "Nombre", grupo.IdComunidad);
            ViewBag.IdLiderGrupo = new SelectList(db.Miembros, "IdMiembro", "Nombres", grupo.IdLiderGrupo);
            ViewBag.IdTipoGrupo = new SelectList(db.Tipo_Grupo, "IdTipoGrupo", "Descripcion", grupo.IdTipoGrupo);
            return View(grupo);
        }

        // GET: Grupoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Grupo grupo = db.Grupoes.Find(id);
            if (grupo == null)
            {
                return HttpNotFound();
            }
            return View(grupo);
        }

        // POST: Grupoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Grupo grupo = db.Grupoes.Find(id);
            db.Grupoes.Remove(grupo);
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
