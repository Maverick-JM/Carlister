using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Carlister.Common.Data;

namespace Carlister.Web.Controllers
{
    public class EnquiryController : Controller
    {
        private ILifetimeScope DiContainer;

        public EnquiryController(ILifetimeScope container)
        {
            this.DiContainer = container;
        }

        // GET: Enquiry
        public ActionResult Index()
        {
            using (var db = this.DiContainer.Resolve<IEnquiryDataSource>())
            {
                return View();
            }
        }
    }
}