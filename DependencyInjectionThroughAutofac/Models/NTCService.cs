using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjectionThroughAutofac.Models
{
    public class NTCService
    {
        public string Name { get; set; }

        public bool IsServiceExecuting { get; set; }
    }
}