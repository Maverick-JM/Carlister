using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Carlister.Common.Data;
using Carlister.Web.ViewModels.Enquiries;
using Carlister.Web.ViewModels.Cars;

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
        public ActionResult Submit(EnquiryViewModel model)
        {
            if (ModelState.IsValid)
            {
                using (var db = this.DiContainer.Resolve<IEnquiryDataSource>())
                {
                    var enquiry = BLL.Enquiries.EnquiryFactory.CreateEnquiry(model);
                    enquiry.Insert(db);
                }

                return View("ThankYou");
            }
            else
            {
                using (var db = this.DiContainer.Resolve<ICarDataSource>())
                {
                    var car = BLL.Cars.Car.GetCar(model.CarID, db);
                    return View("~/Views/Car/Index.cshtml", new CarDetailsViewModel(car, model));
                }
            }
        }

        public ActionResult List()
        {
            using (var db = this.DiContainer.Resolve<IEnquiryDataSource>())
            {
                return View(BLL.Enquiries.Enquiry.GetEnquiries(db));
            }
        }
    }
}