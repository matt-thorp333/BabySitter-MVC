using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace BabySitter.Models
{
    public class NightOut
    {
        [DisplayName("Start Time")]
        public DateTime StartTime { get; set; }

        [DisplayName("End Time")]
        public DateTime EndTime { get; set; }

    }
}