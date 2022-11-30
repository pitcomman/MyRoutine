using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class CarrierCategory
    {
        public string CarrierCateg { get; set; } = null!;
        public string? CarrierCategName { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
