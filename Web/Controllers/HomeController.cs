using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Controller;
using Model;
namespace WebView.Controllers
{
    public class HomeController : System.Web.Mvc.Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            FuncionarioController funcionario = new FuncionarioController ();
            IList<Funcionario> func;
            func = funcionario.Listar();
            
            return View(func);
        }

    }
}
