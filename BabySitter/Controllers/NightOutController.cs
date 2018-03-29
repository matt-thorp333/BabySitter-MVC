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
            return 0;
        }

        internal int CalculateAsleepPay(DateTime bedTime, DateTime endTime)
        {
            return 0;
        }

        internal int CalculateLatePay(DateTime startTime, DateTime endTime)
        {
            return 0;
        }
    }
}