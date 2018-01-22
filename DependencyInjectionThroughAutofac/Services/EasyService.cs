using DependencyInjectionThroughAutofac.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjectionThroughAutofac.Services
{
    public class EasyService : IDummyService
    {
        public string GetServiceName()
        {
            return "Easy Service 1.0";
        }

        public bool IsServiceRunning()
        {
            return true;
        }
    }
}