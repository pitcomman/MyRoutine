using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Carrier
    {
        public string CarrierName { get; set; } = null!;
        public string CarrierCateg { get; set; } = null!;
        public string? Remarks { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
