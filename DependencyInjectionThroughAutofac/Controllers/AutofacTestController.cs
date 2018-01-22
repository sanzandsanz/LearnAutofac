using DependencyInjectionThroughAutofac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DependencyInjectionThroughAutofac.Controllers
{
    public class AutofacTestController : Controller
    {

        private readonly IDummyService service;

        //public AutofacTestController()
        //{
           
        //}

        public AutofacTestController(IDummyService service)
        {
            this.service = service;
        }

        // GET: AutofacTest
        public ActionResult Index()
        {
            var model = new NTCService();
            model.Name = service.GetServiceName();
            model.IsServiceExecuting = service.IsServiceRunning();

            return View(model);
        }
    }
}