using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class MachineProductPlan
    {
        public DateTime ProductDate { get; set; }
        public string MachineNo { get; set; } = null!;
        public decimal ProductPlanQty { get; set; }
        public string Unit { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
