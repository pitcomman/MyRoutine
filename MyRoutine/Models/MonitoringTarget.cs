using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class MonitoringTarget
    {
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string MonitoringGroup { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public string TargetKind { get; set; } = null!;
        public string TargetType { get; set; } = null!;
        public decimal TargetValue { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
