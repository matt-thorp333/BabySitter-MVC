﻿using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitter.Controllers;

namespace BabySitter.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void HomeIndex()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

    }
}
