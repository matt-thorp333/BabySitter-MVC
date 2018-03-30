using BabySitter.Models;
using System;
using System.Web.Mvc;

namespace BabySitter.Controllers
{
    public class NightOutController : Controller
    {
        
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            var model = CreateResultModel(form);

            return null;
        }

        internal int CalculateAwakePay(DateTime startTime, DateTime bedTime)
        {
            var hours = Convert.ToInt16(bedTime.Subtract(startTime).TotalHours);
            return (hours < 1) ? 0 : hours * 12;
        }

        internal int CalculateAsleepPay(DateTime bedTime)
        {
            var hours = Convert.ToInt16(DateTime.Today.AddDays(1).Subtract(bedTime).TotalHours);
            return (hours < 1) ? 0 : hours * 8;
        }

        internal int CalculateLatePay(DateTime endTime)
        {
            var hours = Convert.ToInt16(endTime.Subtract(DateTime.Today.AddDays(1)).TotalHours);
            return (hours < 1) ? 0 : hours * 16;
        }

        internal NightOut_Result CreateResultModel(FormCollection form)
        {
            var startTime = Convert.ToDateTime(form["StartTime"]);
            var endTime = Convert.ToDateTime(form["EndTime"]);
            var bedTime = Convert.ToDateTime(form["BedTime"]);

            var awakePay = CalculateAwakePay(startTime, bedTime);
            var asleepPay = CalculateAsleepPay(bedTime);
            var latePay = CalculateLatePay(endTime);

            return new NightOut_Result
            {
                StartTime = startTime,
                EndTime = endTime,
                BedTime = bedTime,
                AwakePay = awakePay,
                AsleepPay = asleepPay,
                LatePay = latePay
            };
        }
    }
}