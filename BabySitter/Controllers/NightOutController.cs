﻿using BabySitter.Models;
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
            return View(model);
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

        internal NightOut CreateResultModel(FormCollection form)
        {
            var startTime = Convert.ToDateTime(form["StartTime"]);
            var endTime = Convert.ToDateTime(form["EndTime"]);
            var bedTime = Convert.ToDateTime(form["BedTime"]);

            var awakePay = 0;
            var asleepPay = 0;
            if (bedTime < endTime)
            {
                awakePay = CalculateAwakePay(startTime, bedTime);
                asleepPay = CalculateAsleepPay(bedTime);
            }                
            else
            {
                awakePay = CalculateAwakePay(startTime, endTime);
            }
                           
            var latePay = CalculateLatePay(endTime);

            return new NightOut
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