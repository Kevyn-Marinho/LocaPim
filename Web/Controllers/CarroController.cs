using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Controller;
using Model;

namespace WebView.Controllers
{
    public class CarroController : System.Web.Mvc.Controller
    {
        //
        // GET: /Carro/

        public ActionResult Index()
        {
            Controller.CarroController carro = new Controller.CarroController();
            
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
            Controller.CarroController con = new Controller.CarroController(carro);
            ViewBag.msg = con.Adiciona();

            return RedirectToAction("Index");
        }

    }
}
