using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Carlister.Web;
using Carlister.Web.Controllers;

namespace Carlister.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            var result = (RedirectToRouteResult)controller.Index();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Permanent);
            Assert.AreEqual("Car", result.RouteValues["controller"]);
            Assert.AreEqual("List", result.RouteValues["action"]);
        }

        [TestMethod]
        public void Error()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Error() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
