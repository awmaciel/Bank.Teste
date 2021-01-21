using Bank.Portifolio.Business.Application.Interfaces;
using Bank.Portifolio.Business.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bank.Portifolio.Business.Presenter.Controllers
{
    public class ClientController : Controller
    {
        // GET: Client
        private readonly IClienteAppService _ClienteAppService;

        public ClientController(IClienteAppService ClienteAppService)
        {
            _ClienteAppService = ClienteAppService;
        }
        public ActionResult Index()
        {
            if (ModelState.IsValid)
            {
                return View(_ClienteAppService.GetAll());
            }
            else
                return View("");
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Client/Create
        public ActionResult Create()
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            else
                return View("");
        }

        // POST: Client/Create
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

        // GET: Client/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Client/Edit/5
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

        // GET: Client/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Client/Delete/5
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
