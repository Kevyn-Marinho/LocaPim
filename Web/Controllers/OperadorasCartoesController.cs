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
    public class OperadorasCartoesController : Controller
    {
        private EntidadesContext db = new EntidadesContext();

        // GET: OperadorasCartoes
        public ActionResult Index()
        {
            return View(db.OperadorasDeCredito.ToList());
        }

        // GET: OperadorasCartoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OperadoraCartao operadoraCartao = db.OperadorasDeCredito.Find(id);
            if (operadoraCartao == null)
            {
                return HttpNotFound();
            }
            return View(operadoraCartao);
        }

        // GET: OperadorasCartoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OperadorasCartoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdOperadoraCarta,Bandeira,Ativo")] OperadoraCartao operadoraCartao)
        {
            if (ModelState.IsValid)
            {
                db.OperadorasDeCredito.Add(operadoraCartao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(operadoraCartao);
        }

        // GET: OperadorasCartoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OperadoraCartao operadoraCartao = db.OperadorasDeCredito.Find(id);
            if (operadoraCartao == null)
            {
                return HttpNotFound();
            }
            return View(operadoraCartao);
        }

        // POST: OperadorasCartoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdOperadoraCarta,Bandeira,Ativo")] OperadoraCartao operadoraCartao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(operadoraCartao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(operadoraCartao);
        }

        // GET: OperadorasCartoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OperadoraCartao operadoraCartao = db.OperadorasDeCredito.Find(id);
            if (operadoraCartao == null)
            {
                return HttpNotFound();
            }
            return View(operadoraCartao);
        }

        // POST: OperadorasCartoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OperadoraCartao operadoraCartao = db.OperadorasDeCredito.Find(id);
            db.OperadorasDeCredito.Remove(operadoraCartao);
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
