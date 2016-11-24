﻿using System;
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
    public class CartoesDeCreditoController : Controller
    {
        private EntidadesContext db = new EntidadesContext();

        // GET: CartoesDeCredito
        public ActionResult Index()
        {
            return View(db.CartoesDeCredito.Include(c => c.IdOperadoraCartao).ToList());
        }

        // GET: CartoesDeCredito/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CartaoDeCredito cartaoDeCredito = db.CartoesDeCredito.Find(id);
            if (cartaoDeCredito == null)
            {
                return HttpNotFound();
            }
            return View(cartaoDeCredito);
        }

        // GET: CartoesDeCredito/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CartoesDeCredito/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdCartaoDeCredito,Validade,NumeroCartao,CodigoSeguranca,NomeCartao,Ativo,IdCliente,IdOperadoraCartao")] CartaoDeCredito cartaoDeCredito)
        {
            if (ModelState.IsValid)
            {
                db.CartoesDeCredito.Add(cartaoDeCredito);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cartaoDeCredito);
        }

        // GET: CartoesDeCredito/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CartaoDeCredito cartaoDeCredito = db.CartoesDeCredito.Find(id);
            if (cartaoDeCredito == null)
            {
                return HttpNotFound();
            }
            return View(cartaoDeCredito);
        }

        // POST: CartoesDeCredito/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdCartaoDeCredito,Validade,NumeroCartao,CodigoSeguranca,NomeCartao,Ativo,IdCliente,IdOperadoraCartao")] CartaoDeCredito cartaoDeCredito)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cartaoDeCredito).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cartaoDeCredito);
        }

        // GET: CartoesDeCredito/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CartaoDeCredito cartaoDeCredito = db.CartoesDeCredito.Find(id);
            if (cartaoDeCredito == null)
            {
                return HttpNotFound();
            }
            return View(cartaoDeCredito);
        }

        // POST: CartoesDeCredito/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CartaoDeCredito cartaoDeCredito = db.CartoesDeCredito.Find(id);
            db.CartoesDeCredito.Remove(cartaoDeCredito);
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
