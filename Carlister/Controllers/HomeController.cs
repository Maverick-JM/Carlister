using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Carlister.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToActionPermanent(nameof(CarController.List), "Car");
        }

        public ActionResult Error()
        {
            return View();
        }
    }
}
