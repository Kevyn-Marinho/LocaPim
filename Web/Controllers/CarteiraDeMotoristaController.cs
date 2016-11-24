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
    public class CarteiraDeMotoristaController : Controller
    {
        private EntidadesContext db = new EntidadesContext();

        // GET: CarteiraDeMotorista
        public ActionResult Index()
        {
            return View(db.CarteirasDeMotorista.ToList());
        }

        // GET: CarteiraDeMotorista/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarteiraDeMotorista carteiraDeMotorista = db.CarteirasDeMotorista.Find(id);
            if (carteiraDeMotorista == null)
            {
                return HttpNotFound();
            }
            return View(carteiraDeMotorista);
        }

        // GET: CarteiraDeMotorista/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CarteiraDeMotorista/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Cnh,DataEmissao,Vencimento,Tipo")] CarteiraDeMotorista carteiraDeMotorista)
        {
            if (ModelState.IsValid)
            {
                db.CarteirasDeMotorista.Add(carteiraDeMotorista);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(carteiraDeMotorista);
        }

        // GET: CarteiraDeMotorista/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarteiraDeMotorista carteiraDeMotorista = db.CarteirasDeMotorista.Find(id);
            if (carteiraDeMotorista == null)
            {
                return HttpNotFound();
            }
            return View(carteiraDeMotorista);
        }

        // POST: CarteiraDeMotorista/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Cnh,DataEmissao,Vencimento,Tipo")] CarteiraDeMotorista carteiraDeMotorista)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carteiraDeMotorista).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(carteiraDeMotorista);
        }

        // GET: CarteiraDeMotorista/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarteiraDeMotorista carteiraDeMotorista = db.CarteirasDeMotorista.Find(id);
            if (carteiraDeMotorista == null)
            {
                return HttpNotFound();
            }
            return View(carteiraDeMotorista);
        }

        // POST: CarteiraDeMotorista/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CarteiraDeMotorista carteiraDeMotorista = db.CarteirasDeMotorista.Find(id);
            db.CarteirasDeMotorista.Remove(carteiraDeMotorista);
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
