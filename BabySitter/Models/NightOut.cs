using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BabySitter.Models
{
    public class NightOut
    {
        [DisplayName("Start Time")]
        [DisplayFormat(DataFormatString = "{0:t}")]
        public DateTime StartTime { get; set; }

        [DisplayName("End Time")]
        [DisplayFormat(DataFormatString = "{0:t}")]
        public DateTime EndTime { get; set; }

        [DisplayName("Bed Time")]
        [DisplayFormat(DataFormatString = "{0:t}")]
        public DateTime BedTime { get; set; }

        [DisplayName("Awake Pay")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int AwakePay { get; set; }

        [DisplayName("Asleep Pay")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int AsleepPay { get; set; }

        [DisplayName("Late Pay")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public int LatePay { get; set; }
    }
}