using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CampDios.Modelo;
using CampDios.Modelo.ViewModels;

namespace CampDios.Controllers
{
    public class Programacion_de_ReunioneController : Controller
    {
        private CampDiosEntities db = new CampDiosEntities();

        // GET: Programacion_de_Reunione
        public ActionResult Index()
        {
            var programacion_de_Reuniones = db.Programacion_de_Reuniones.Include(p => p.Grupo);
            return View(programacion_de_Reuniones.ToList());
        }

        // GET: Programacion_de_Reunione/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Programacion_de_Reunione programacion_de_Reunione = db.Programacion_de_Reuniones.Find(id);
            if (programacion_de_Reunione == null)
            {
                return HttpNotFound();
            }
            return View(programacion_de_Reunione);
        }

        // GET: Programacion_de_Reunione/Create
        public ActionResult Create()
        {
            ViewBag.IdGrupo = new SelectList(db.Grupoes, "IdGrupo", "Nombre");
            return View(new Programacion_de_ReunioneViewModel());
        }

        // POST: Programacion_de_Reunione/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Programacion_de_ReunioneViewModel viewModel)
        {
            //[Bind(Include = "IdProgramacion,IdGrupo,Fecha,Descripcion")]
            if (ModelState.IsValid)
            {
                //Ejemplo de ViewModel 
                var nuevaProgramacion = new Programacion_de_Reunione()
                {
                    Descripcion = viewModel.Descripcion,
                    IdGrupo = viewModel.IdGrupo,
                    Fecha = viewModel.Fecha.Date.Add(viewModel.Hora.TimeOfDay)
            };

                db.Programacion_de_Reuniones.Add(nuevaProgramacion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdGrupo = new SelectList(db.Grupoes, "IdGrupo", "Nombre", viewModel.IdGrupo);
            return View(viewModel);
        }

        // GET: Programacion_de_Reunione/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Programacion_de_Reunione programacion_de_Reunione = db.Programacion_de_Reuniones.Find(id);
            if (programacion_de_Reunione == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdGrupo = new SelectList(db.Grupoes, "IdGrupo", "Nombre", programacion_de_Reunione.IdGrupo);
            return View(programacion_de_Reunione);
        }

        // POST: Programacion_de_Reunione/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdProgramacion,IdGrupo,Fecha,Descripcion")] Programacion_de_Reunione programacion_de_Reunione)
        {
            if (ModelState.IsValid)
            {
                db.Entry(programacion_de_Reunione).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdGrupo = new SelectList(db.Grupoes, "IdGrupo", "Nombre", programacion_de_Reunione.IdGrupo);
            return View(programacion_de_Reunione);
        }

        // GET: Programacion_de_Reunione/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Programacion_de_Reunione programacion_de_Reunione = db.Programacion_de_Reuniones.Find(id);
            if (programacion_de_Reunione == null)
            {
                return HttpNotFound();
            }
            return View(programacion_de_Reunione);
        }

        // POST: Programacion_de_Reunione/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Programacion_de_Reunione programacion_de_Reunione = db.Programacion_de_Reuniones.Find(id);
            db.Programacion_de_Reuniones.Remove(programacion_de_Reunione);
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
