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
    public class TiposDeContatosController : Controller
    {
        private EntidadesContext db = new EntidadesContext();

        // GET: TiposDeContatos
        public ActionResult Index()
        {
            return View(db.TiposDeContatos.ToList());
        }

        // GET: TiposDeContatos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDeContato tipoDeContato = db.TiposDeContatos.Find(id);
            if (tipoDeContato == null)
            {
                return HttpNotFound();
            }
            return View(tipoDeContato);
        }

        // GET: TiposDeContatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TiposDeContatos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTipoDeContato,Descricao")] TipoDeContato tipoDeContato)
        {
            if (ModelState.IsValid)
            {
                db.TiposDeContatos.Add(tipoDeContato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoDeContato);
        }

        // GET: TiposDeContatos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDeContato tipoDeContato = db.TiposDeContatos.Find(id);
            if (tipoDeContato == null)
            {
                return HttpNotFound();
            }
            return View(tipoDeContato);
        }

        // POST: TiposDeContatos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTipoDeContato,Descricao")] TipoDeContato tipoDeContato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoDeContato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoDeContato);
        }

        // GET: TiposDeContatos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoDeContato tipoDeContato = db.TiposDeContatos.Find(id);
            if (tipoDeContato == null)
            {
                return HttpNotFound();
            }
            return View(tipoDeContato);
        }

        // POST: TiposDeContatos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoDeContato tipoDeContato = db.TiposDeContatos.Find(id);
            db.TiposDeContatos.Remove(tipoDeContato);
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
