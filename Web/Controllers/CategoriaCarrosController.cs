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
    public class CategoriaCarrosController : Controller
    {
        private EntidadesContext db = new EntidadesContext();

        // GET: CategoriaCarros
        public ActionResult Index()
        {
            return View(db.Categorias.ToList());
        }

        // GET: CategoriaCarros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaCarro categoriaCarro = db.Categorias.Find(id);
            if (categoriaCarro == null)
            {
                return HttpNotFound();
            }
            return View(categoriaCarro);
        }

        // GET: CategoriaCarros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaCarros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCategoriaCarro,Nome,Descricao")] CategoriaCarro categoriaCarro)
        {
            if (ModelState.IsValid)
            {
                db.Categorias.Add(categoriaCarro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categoriaCarro);
        }

        // GET: CategoriaCarros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaCarro categoriaCarro = db.Categorias.Find(id);
            if (categoriaCarro == null)
            {
                return HttpNotFound();
            }
            return View(categoriaCarro);
        }

        // POST: CategoriaCarros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCategoriaCarro,Nome,Descricao")] CategoriaCarro categoriaCarro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoriaCarro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaCarro);
        }

        // GET: CategoriaCarros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CategoriaCarro categoriaCarro = db.Categorias.Find(id);
            if (categoriaCarro == null)
            {
                return HttpNotFound();
            }
            return View(categoriaCarro);
        }

        // POST: CategoriaCarros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoriaCarro categoriaCarro = db.Categorias.Find(id);
            db.Categorias.Remove(categoriaCarro);
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
