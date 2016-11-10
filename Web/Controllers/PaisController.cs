using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using Business;

namespace WebView.Controllers
{
    public class PaisController : Controller
    {
        //
        // GET: /Pais/

        public ActionResult Index()
        {
            IList<Pais> paises = new PaisCtl().Listar();
            ViewBag.Paises = paises;
            return View();
        }

        //
        // GET: /Pais/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Pais/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pais/Create

        [HttpPost]
        public ActionResult Create(Pais pais)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    PaisCtl ctl = new PaisCtl();
                    ctl.Adicionar(pais);
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pais/Edit/5

        public ActionResult Edit(int id)
        {
            PaisCtl ctl = new PaisCtl();
            Pais pais = ctl.BuscaPorId(id);

            return View(pais);
        }

        //
        // POST: /Pais/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Pais model)
        {
            try
            {
                PaisCtl ctl = new PaisCtl();
                Pais pais = ctl.BuscaPorId(id);

                if (ModelState.IsValid)
                {
                    pais = model;
                    ctl.SalvarAlteracoes();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Pais/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Pais/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
