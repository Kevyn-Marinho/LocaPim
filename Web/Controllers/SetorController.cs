using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebView.Controllers
{
    public class SetorController : System.Web.Mvc.Controller
    {
        //
        // GET: /Setor/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Setor/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Setor/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Setor/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Setor/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Setor/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Setor/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Setor/Delete/5

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
