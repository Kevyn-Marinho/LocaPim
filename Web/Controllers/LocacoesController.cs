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
            var locacoes = db.Locacoes.Include(l => l.Carro).Include(l => l.Cartao).Include(l => l.Cliente);
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
            ViewBag.IdCarro = new SelectList(db.Carros, "IdCarro", "Placa");
            ViewBag.IdCartaoDeCredito = new SelectList(db.CartoesDeCredito, "IdCartaoDeCredito", "NumeroCartao");
            ViewBag.Id = new SelectList(db.Clientes, "Id", "Nome");
            return View();
        }

        // POST: Locacoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdLocacao,Id,IdCartaoDeCredito,IdCarro,DataRetirada,DataDevolucao,Devolvido")] Locacao locacao)
        {
            if (ModelState.IsValid)
            {
                db.Locacoes.Add(locacao);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCarro = new SelectList(db.Carros, "IdCarro", "Placa", locacao.IdCarro);
            ViewBag.IdCartaoDeCredito = new SelectList(db.CartoesDeCredito, "IdCartaoDeCredito", "NumeroCartao", locacao.IdCartaoDeCredito);
            ViewBag.Id = new SelectList(db.Clientes, "Id", "Nome", locacao.Id);
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
            ViewBag.IdCarro = new SelectList(db.Carros, "IdCarro", "Placa", locacao.IdCarro);
            ViewBag.IdCartaoDeCredito = new SelectList(db.CartoesDeCredito, "IdCartaoDeCredito", "NumeroCartao", locacao.IdCartaoDeCredito);
            ViewBag.Id = new SelectList(db.Clientes, "Id", "Nome", locacao.Id);
            return View(locacao);
        }

        // POST: Locacoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdLocacao,Id,IdCartaoDeCredito,IdCarro,DataRetirada,DataDevolucao,Devolvid")] Locacao locacao)
        {
            if (ModelState.IsValid)
            {
                db.Entry(locacao).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCarro = new SelectList(db.Carros, "IdCarro", "Placa", locacao.IdCarro);
            ViewBag.IdCartaoDeCredito = new SelectList(db.CartoesDeCredito, "IdCartaoDeCredito", "NumeroCartao", locacao.IdCartaoDeCredito);
            ViewBag.Id = new SelectList(db.Clientes, "Id", "Nome", locacao.Id);
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

        [HttpPost]
        public ActionResult BuscaCliente(string cpf)
        {
            //Consulta
            var resultado = db.Clientes.Single(u => u.Cpf == cpf);
            if(resultado != null) { 
                ViewBag.IdCartaoDeCredito = new SelectList(db.CartoesDeCredito.Select(c => c.Cliente == resultado ) , "IdCartaoDeCredito", "NumeroCartao");
                ViewBag.Id = new SelectList(db.Clientes.Select(u => u.Cpf == cpf), "Id", "Nome"+ " " + "Cpf", "Id");
            }
            //Serialização para Json
            return Json(resultado);
        }

        public ActionResult Devolucao(int? id)
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
            locacao.Devolvido = true;
            ViewBag.IdCarro = new SelectList(db.Carros, "IdCarro", "Placa", locacao.IdCarro);
            ViewBag.IdCartaoDeCredito = new SelectList(db.CartoesDeCredito, "IdCartaoDeCredito", "NumeroCartao", locacao.IdCartaoDeCredito);
            ViewBag.Id = new SelectList(db.Clientes, "Id", "Nome", locacao.Id);
            return View(locacao);
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
