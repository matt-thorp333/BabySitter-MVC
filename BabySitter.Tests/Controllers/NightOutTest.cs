using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitter.Controllers;

namespace BabySitter.Tests.Controllers
{
    [TestClass]
    public class NightOutTest
    {
        [TestMethod]
        public void NightOutIndex()
        {
            // Arrange
            NightOutController controller = new NightOutController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
