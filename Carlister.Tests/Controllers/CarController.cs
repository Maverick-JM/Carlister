using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Carlister.Web;
using Carlister.Web.Controllers;
using Autofac.Extras.Moq;
using Autofac;
using Carlister.Common.Data;

namespace Carlister.Tests.Controllers
{
    [TestClass]
    public class CarControllerTest
    {
        [TestMethod]
        public void IndexNoValue()
        {
            using (var moq = AutoMock.GetLoose())
            using (var scope = moq.Container.BeginLifetimeScope())
            {
                // Arrange
                CarController controller = new CarController(scope);

                // Act
                var result = (RedirectToRouteResult)controller.Index(null);

                // Assert
                Assert.IsNotNull(result);
                Assert.IsFalse(result.Permanent);
                Assert.AreEqual("Home", result.RouteValues["controller"]);
                Assert.AreEqual("Error", result.RouteValues["action"]);
            }
        }

        [TestMethod]
        public void IndexWrongValue()
        {
            using (var moq = AutoMock.GetLoose())
            using (var scope = moq.Container.BeginLifetimeScope())
            {
                // Arrange
                CarController controller = new CarController(scope);
                var car = new Mocking.Car()
                {
                    CarID = 1,
                    Comments = "comments",
                    ContactName = "contact name"
                };
                var data = new List<Mocking.Car>() { car };
                moq.Provide<ICarDataSource>(new Mocking.FakeDb(data));

                // Act
                var result = (RedirectToRouteResult)controller.Index(-1);

                // Assert
                Assert.IsNotNull(result);
                Assert.IsFalse(result.Permanent);
                Assert.AreEqual("Home", result.RouteValues["controller"]);
                Assert.AreEqual("Error", result.RouteValues["action"]);
            }
        }

        [TestMethod]
        public void IndexCorrectValue()
        {
            using (var moq = AutoMock.GetLoose())
            using (var scope = moq.Container.BeginLifetimeScope())
            {
                // Arrange
                CarController controller = new CarController(scope);
                var car = new Mocking.Car()
                {
                    CarID = 1,
                    Comments = "comments",
                    ContactName = "contact name"
                };
                var data = new List<Mocking.Car>() { car };
                moq.Provide<ICarDataSource>(new Mocking.FakeDb(data));

                // Act
                ViewResult result = controller.Index(car.CarID) as ViewResult;

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(car.CarID, (result.Model as Web.ViewModels.Cars.CarDetailsViewModel).Car.CarID);
                Assert.AreEqual(0, (result.Model as Web.ViewModels.Cars.CarDetailsViewModel).Enquiry.EnquiryID);
            }
        }

        [TestMethod]
        public void List()
        {
            using (var moq = AutoMock.GetLoose())
            using (var scope = moq.Container.BeginLifetimeScope())
            {
                // Arrange
                CarController controller = new CarController(scope);

                var data = new List<Mocking.Car>()
                {
                    new Mocking.Car(),
                    new Mocking.Car(),
                    new Mocking.Car()
                };
                moq.Provide<ICarDataSource>(new Mocking.FakeDb(data));

                // Act
                ViewResult result = controller.List() as ViewResult;

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(3, (result.Model as Web.ViewModels.Cars.CarListViewModel).Cars.Count);
            }
        }
    }
}
