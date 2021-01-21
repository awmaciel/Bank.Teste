using Bank.Portifolio.Business.Application.Interfaces;
using Bank.Portifolio.Business.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Bank.Portifolio.Business.Presenter.Controllers
{
    public class BusinessController : Controller
    {
        private readonly IBusinessAppService _businessAppService;
        private readonly IClienteAppService _clienteAppService;
        private readonly IPortifolioAppService _portifolioAppService;
        public BusinessController(
            IBusinessAppService BusinessAppService,
            IClienteAppService ClienteAppService,
            IPortifolioAppService PortifolioAppService
            )
        {
            _businessAppService = BusinessAppService;
            _clienteAppService = ClienteAppService;
            _portifolioAppService = PortifolioAppService;
        }
        // GET: Business
        public ActionResult Index()
        {
            return View(_businessAppService.GetCategoriesByBusiness());
        }

        // GET: Business/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Business/Create
        public ActionResult Create()
        {
            List<SelectListItem> ObjList = new List<SelectListItem>();
            List<SelectListItem> ObjListPortifolio = new List<SelectListItem>();

            var itemsClient = _clienteAppService.GetAll();
            var itemsObjListPortifolio = _portifolioAppService.GetAll();

            foreach (var item in itemsObjListPortifolio)
            {
                ObjListPortifolio.Add(new SelectListItem
                {
                    Text = item.NameProtifolio,
                    Value = item.IdPortifolio.ToString()
                });
            }

            foreach (var item in itemsClient)
            {
                ObjList.Add(new SelectListItem
                {
                    Text = item.NameClient,
                    Value = item.IdClient.ToString()
                });
            }

            if (itemsClient != null)
                ViewBag.Clients = ObjList;

            if (itemsObjListPortifolio != null)
                ViewBag.Portifolio = ObjListPortifolio;

            return View();
        }

        // POST: Business/Create
        [HttpPost]
        public ActionResult Create(BusinessViewModel bussinesView)
        {
            try
            {
                bussinesView.IdPortifolio = Convert.ToInt32(Request.Form["Portifolio"]);
                bussinesView.IdClient = Convert.ToInt32(Request.Form["Clients"]);

                _businessAppService.CreateBusiness(bussinesView);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View();
            }
        }

        // GET: Business/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Business/Edit/5
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

        // GET: Business/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Business/Delete/5
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
