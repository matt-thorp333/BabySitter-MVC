using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BabySitter.Controllers;
using System;

namespace BabySitter.Tests.Controllers
{
    [TestClass]
    public class NightOutTest
    {
        [TestMethod]
        public void NightOutIndex()
        {
            NightOutController controller = new NightOutController();
            ViewResult result = controller.Index(new FormCollection()) as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestAwakePay_Positive()
        {
            NightOutController controller = new NightOutController();
            int result = controller.CalculateAwakePay(DateTime.Today + new TimeSpan(17, 0, 0), DateTime.Today + new TimeSpan(22, 0, 0));

            Assert.IsTrue(result == 60);
        }

        [TestMethod]
        public void TestAsleepPay_Positive()
        {
            NightOutController controller = new NightOutController();
            int result = controller.CalculateAsleepPay(DateTime.Today + new TimeSpan(22, 0, 0));

            Assert.IsTrue(result == 16);
        }

        [TestMethod]
        public void TestLatePay_Positive()
        {
            NightOutController controller = new NightOutController();
            int result = controller.CalculateLatePay(DateTime.Today + new TimeSpan(28, 0, 0));

            Assert.IsTrue(result == 64);
        }

        [TestMethod]
        public void TestAwakePay_Zero()
        {
            NightOutController controller = new NightOutController();
            int result = controller.CalculateAwakePay(DateTime.Today + new TimeSpan(17, 0, 0), DateTime.Today + new TimeSpan(17, 0, 0));

            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void TestAsleepPay_Zero()
        {
            NightOutController controller = new NightOutController();
            int result = controller.CalculateAsleepPay(DateTime.Today + new TimeSpan(24, 0, 0));

            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void TestLatePay_Zero()
        {
            NightOutController controller = new NightOutController();
            int result = controller.CalculateLatePay(DateTime.Today + new TimeSpan(24, 0, 0));

            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void TestAwakePay_Negative()
        {
            NightOutController controller = new NightOutController();
            int result = controller.CalculateAwakePay(DateTime.Today + new TimeSpan(17, 0, 0), DateTime.Today + new TimeSpan(15, 0, 0));

            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void TestAsleepPay_Negative()
        {
            NightOutController controller = new NightOutController();
            int result = controller.CalculateAsleepPay(DateTime.Today + new TimeSpan(26, 0, 0));

            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void TestLatePay_Negative()
        {
            NightOutController controller = new NightOutController();
            int result = controller.CalculateLatePay(DateTime.Today + new TimeSpan(22, 0, 0));

            Assert.IsTrue(result == 0);
        }

        [TestMethod]
        public void TestBedTime_After_EndTime()
        {
            NightOutController controller = new NightOutController();

            var startTime = (DateTime.Today + new TimeSpan(17, 0, 0)).ToString();
            var endTime = (DateTime.Today + new TimeSpan(19, 0, 0)).ToString();
            var bedTime = (DateTime.Today + new TimeSpan(21, 0, 0)).ToString();

            var form = new FormCollection {
                {"StartTime", startTime},
                {"EndTime", endTime},
                {"BedTime", bedTime}
            };

            var result = controller.CreateResultModel(form);

            Assert.IsTrue(result.AwakePay == 24);
            Assert.IsTrue(result.AsleepPay == 0);
            Assert.IsTrue(result.LatePay == 0);
        }
    }
}
