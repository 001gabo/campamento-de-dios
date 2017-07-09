﻿using System;
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
    public class Tipo_GrupoController : Controller
    {
        private CampDiosEntities db = new CampDiosEntities();

        // GET: Tipo_Grupo
        public ActionResult Index()
        {
            return View(db.Tipo_Grupo.ToList());
        }

        // GET: Tipo_Grupo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo_Grupo tipo_Grupo = db.Tipo_Grupo.Find(id);
            if (tipo_Grupo == null)
            {
                return HttpNotFound();
            }
            return View(tipo_Grupo);
        }

        // GET: Tipo_Grupo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tipo_Grupo/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTipoGrupo,Descripcion")] Tipo_Grupo tipo_Grupo)
        {
            if (ModelState.IsValid)
            {
                db.Tipo_Grupo.Add(tipo_Grupo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipo_Grupo);
        }

        // GET: Tipo_Grupo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo_Grupo tipo_Grupo = db.Tipo_Grupo.Find(id);
            if (tipo_Grupo == null)
            {
                return HttpNotFound();
            }
            return View(tipo_Grupo);
        }

        // POST: Tipo_Grupo/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTipoGrupo,Descripcion")] Tipo_Grupo tipo_Grupo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipo_Grupo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipo_Grupo);
        }

        // GET: Tipo_Grupo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tipo_Grupo tipo_Grupo = db.Tipo_Grupo.Find(id);
            if (tipo_Grupo == null)
            {
                return HttpNotFound();
            }
            return View(tipo_Grupo);
        }

        // POST: Tipo_Grupo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tipo_Grupo tipo_Grupo = db.Tipo_Grupo.Find(id);
            db.Tipo_Grupo.Remove(tipo_Grupo);
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