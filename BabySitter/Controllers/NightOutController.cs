using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BabySitter.Controllers
{
    public class NightOutController : Controller
    {
        
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            var startTime = Convert.ToDateTime(form["StartTime"]);
            var endTime = Convert.ToDateTime(form["EndTime"]);
            var bedTime = Convert.ToDateTime(form["BedTime"]);

            //var awakePay = CalculateAwakePay();
            //var asleepPay = CalculateAsleepPay();
            //var latePay = CalculateLatePay();
            return null;
        }

        internal int CalculateAwakePay(DateTime startTime, DateTime bedTime)
        {
            var hours = Convert.ToInt16(bedTime.Subtract(startTime).TotalHours);
            return hours * 12;
        }

        internal int CalculateAsleepPay(DateTime bedTime)
        {
            var hours = Convert.ToInt16(DateTime.Today.AddDays(1).Subtract(bedTime).TotalHours);
            return hours * 8;
        }

        internal int CalculateLatePay(DateTime endTime)
        {
            var hours = Convert.ToInt16(endTime.Subtract(DateTime.Today.AddDays(1)).TotalHours);
            return hours * 16;
        }
    }
}