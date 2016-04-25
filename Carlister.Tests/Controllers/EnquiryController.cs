using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Carlister.Web;
using Carlister.Web.Controllers;
using Autofac.Extras.Moq;
using Carlister.Web.ViewModels.Enquiries;
using System.ComponentModel.DataAnnotations;
using Carlister.Common.Data;
using Moq;

namespace Carlister.Tests.Controllers
{
    [TestClass]
    public class EnquiryControllerTest
    {
        private EnquiryViewModel failModel;
        private EnquiryViewModel successModel;

        public EnquiryControllerTest()
        {
            failModel = new EnquiryViewModel();
            successModel = new EnquiryViewModel()
            {
                CarID = 1,
                Email = "email@gmail.com",
                Name = "Justin",
                EnquiryID = 0
            };
        }

        [TestMethod]
        public void TestValidationFail()
        {
            // Arrange
            var context = new ValidationContext(failModel);
            var results = new List<ValidationResult>();

            // Act
            bool result = Validator.TryValidateObject(failModel, context, results);

            // Assert
            Assert.IsFalse(result);
            Assert.AreEqual(2, results.Count);
        }

        [TestMethod]
        public void TestValidationSuccess()
        {
            // Arrange
            var context = new ValidationContext(successModel);
            var results = new List<ValidationResult>();

            // Act
            bool result = Validator.TryValidateObject(successModel, context, results);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Submit()
        {
            using (var moq = AutoMock.GetLoose())
            using (var scope = moq.Container.BeginLifetimeScope())
            {
                // Arrange
                EnquiryController controller = new EnquiryController(scope);

                var db = new Mocking.FakeDb();
                moq.Provide<IEnquiryDataSource>(db);

                // Act
                var result = controller.Submit(successModel) as ViewResult;

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual(1, db.GetEnquiries().Count());
            }
        }
    }
}
