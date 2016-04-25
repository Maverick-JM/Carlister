using Autofac;
using Carlister.Web.ViewModels.Cars;
using Carlister.Web.ViewModels.Enquiries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carlister.Web.Controllers
{
    public class CarController : Controller
    {
        private ILifetimeScope DiContainer = null;

        public CarController(ILifetimeScope container)
        {
            this.DiContainer = container;
        }

        /// <summary>
        /// View the details of a car and enquiry about it - if you want to
        /// </summary>
        /// <param name="id">CarID of the car you want to view</param>
        /// <returns></returns>
        public ActionResult Index(int? id)
        {
            if (id.HasValue)
            {
                using (var db = this.DiContainer.Resolve<Common.Data.ICarDataSource>())
                {
                    var car = BLL.Cars.Car.GetCar(id.Value, db);

                    if (car != null)
                    {
                        CarDetailsViewModel model = new CarDetailsViewModel(car);

                        return View("Index", model);
                    }
                    else
                        return RedirectToAction(nameof(HomeController.Error), "Home");
                }
            }
            else
                return RedirectToAction(nameof(HomeController.Error), "Home");
        }

        public ActionResult List()
        {
            using (var db = this.DiContainer.Resolve<Common.Data.ICarDataSource>())
            {
                var cars = BLL.Cars.Car.GetCars(db);
                var model = new CarListViewModel(cars);
                return View(model);
            }
        }
    }
}
