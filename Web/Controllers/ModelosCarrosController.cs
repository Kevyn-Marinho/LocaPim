using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dao;
using Model;

namespace Web.Controllers
{
    public class ModelosCarrosController : Controller
    {
        private EntidadesContext db = new EntidadesContext();

        // GET: ModelosCarros
        public ActionResult Index()
        {

            return View(db.Modelo.Include("Marcas").Include("Categoria").ToList());
        }

        // GET: ModelosCarros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModeloCarro modeloCarro = db.Modelo.Include("Marcas").Include("Categoria").Single(m => m.IdModeloCarro == id);
            if (modeloCarro == null)
            {
                return HttpNotFound();
            }

            return View(modeloCarro);
        }

        // GET: ModelosCarros/Create
        public ActionResult Create()
        {
            ViewBag.IdMarcaCarro = new SelectList(db.Marcas, "IdMarcaCarro", "Nome");
            ViewBag.IdCategoriaCarro = new SelectList(db.Categorias, "IdCategoriaCarro", "Nome");
            return View();
        }

        // POST: ModelosCarros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdModeloCarro,Nome,IdMarcaCarro,IdCategoriaCarro")] ModeloCarro modeloCarro)
        {
            if (ModelState.IsValid)
            {
                db.Modelo.Add(modeloCarro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(modeloCarro);
        }

        // GET: ModelosCarros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModeloCarro modeloCarro = db.Modelo.Find(id);
            if (modeloCarro == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdMarcaCarro = new SelectList(db.Marcas, "IdMarcaCarro", "Nome");
            ViewBag.IdCategoriaCarro = new SelectList(db.Categorias, "IdCategoriaCarro", "Nome");

            return View(modeloCarro);
        }

        // POST: ModelosCarros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdModeloCarro,Nome,IdMarcaCarro,IdCategoriaCarro")] ModeloCarro modeloCarro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(modeloCarro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(modeloCarro);
        }

        // GET: ModelosCarros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ModeloCarro modeloCarro = db.Modelo.Include("Marcas").Include("Categoria").Single(m => m.IdModeloCarro == id);
            if (modeloCarro == null)
            {
                return HttpNotFound();
            }

            return View(modeloCarro);
        }

        // POST: ModelosCarros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ModeloCarro modeloCarro = db.Modelo.Find(id);
            db.Modelo.Remove(modeloCarro);
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
