using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using Model;

namespace WebView.Controllers
{
    public class CarroController : System.Web.Mvc.Controller
    {
        //
        // GET: /CarroCtl/

        public ActionResult Index()
        {
            Business.CarroCtl carro = new Business.CarroCtl();
            
            return View(carro.ListaFrota());
        }

        //GET
        public ActionResult Criar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Criar(Carro carro)
        {
            Business.CarroCtl con = new Business.CarroCtl();
            con.Adicionar(carro);

            return RedirectToAction("Index");
        }

    }
}
