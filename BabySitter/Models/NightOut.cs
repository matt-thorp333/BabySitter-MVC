using System;
using System.ComponentModel;

namespace BabySitter.Models
{
    public class NightOut
    {
        [DisplayName("Start Time")]
        public DateTime StartTime { get; set; }

        [DisplayName("End Time")]
        public DateTime EndTime { get; set; }

        [DisplayName("Bed Time")]
        public DateTime BedTime { get; set; }
    }
}