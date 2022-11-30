using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZzProductPlanSummaryGroup
    {
        public DateTime ProductDate { get; set; }
        public string MonitoringGroup { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public string LineId { get; set; } = null!;
        public decimal? DeliveryPlanQty { get; set; }
        public string Unit { get; set; } = null!;
    }
}
