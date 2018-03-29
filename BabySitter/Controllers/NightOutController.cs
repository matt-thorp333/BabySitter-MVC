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
            var startTime = form["StartTime"];
            var endTime = form["EndTime"];
            var bedTime = form["BedTime"];

            //var awakePay = CalculateAwakePay();
            //var asleepPay = CalculateAsleepPay();
            //var latePay = CalculateLatePay();
            return null;
        }
    }
}