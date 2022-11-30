using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ProductDetailPlan
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string MonitoringGroup { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public string LineId { get; set; } = null!;
        public int PlanTime { get; set; }
        public decimal OutPlanQtyPerHour { get; set; }
        public string Unit { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
