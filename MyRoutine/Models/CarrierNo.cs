using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class CarrierNo
    {
        public string CarrierNo1 { get; set; } = null!;
        public string CarrierName { get; set; } = null!;
        public bool DisableFlag { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
