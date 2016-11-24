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
    public class LocacoesController : Controller
    {
        private EntidadesContext db = new EntidadesContext();

        // GET: Locacoes
        public ActionResult Index()
        {
            var locacoes = db.Locacoes.Include(l => l.Carro);
            return View(locacoes.ToList());
        }

        // GET: Locacoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Locacao locacao = db.Locacoes.Find(id);
            if (locacao == null)
            {
                return HttpNotFound();
            }
            return View(locacao);
        }

        // GET: Locacoes/Create
        public ActionResult Create()
        {
            ViewBag.IdCarro = new SelectList(db.Carros, "IdCarro", "Chassi");
            return View();
        }

        // POST: Locacoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdLocacao,IdCliente,IdCartao,IdCarro")] Locacao locacao)
        {
            if (ModelState.IsValid)
            {
                db.Locacoes.Add(locacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCarro = new SelectList(db.Carros, "IdCarro", "Chassi", locacao.IdCarro);
            return View(locacao);
        }

        // GET: Locacoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Locacao locacao = db.Locacoes.Find(id);
            if (locacao == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCarro = new SelectList(db.Carros, "IdCarro", "Chassi", locacao.IdCarro);
            return View(locacao);
        }

        // POST: Locacoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdLocacao,IdCliente,IdCartao,IdCarro")] Locacao locacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(locacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCarro = new SelectList(db.Carros, "IdCarro", "Chassi", locacao.IdCarro);
            return View(locacao);
        }

        // GET: Locacoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Locacao locacao = db.Locacoes.Find(id);
            if (locacao == null)
            {
                return HttpNotFound();
            }
            return View(locacao);
        }

        // POST: Locacoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Locacao locacao = db.Locacoes.Find(id);
            db.Locacoes.Remove(locacao);
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
