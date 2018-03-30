using System.ComponentModel;

namespace BabySitter.Models
{
    public class NightOut_Result : NightOut
    {
        [DisplayName("Awake Pay")]
        public int AwakePay { get; set; }

        [DisplayName("Asleep Pay")]
        public int AsleepPay { get; set; }

        [DisplayName("Late Pay")]
        public int LatePay { get; set; }
    }
}