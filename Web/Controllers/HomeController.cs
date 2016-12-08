using Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Model;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private EntidadesContext db = new EntidadesContext();

        // GET: Home
        public ActionResult Index()
        {
            var resultado = db.Locacoes.Include("Carro").Include("Cliente").ToList().Where(l => l.Devolvido ==false); 
            return View(resultado);
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
            db.SaveChanges();
            ViewBag.IdCarro = new SelectList(db.Carros, "IdCarro", "Placa", locacao.IdCarro);
            ViewBag.IdCartaoDeCredito = new SelectList(db.CartoesDeCredito, "IdCartaoDeCredito", "NumeroCartao", locacao.IdCartaoDeCredito);
            ViewBag.Id = new SelectList(db.Clientes, "Id", "Nome", locacao.Id);
            return RedirectToAction("Index");
        }

    }
}