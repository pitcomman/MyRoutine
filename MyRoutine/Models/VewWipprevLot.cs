using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewWipprevLot
    {
        public DateTime InputDate { get; set; }
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string? LotNo { get; set; }
        public string? LotNoSuffix { get; set; }
        public int? ProcessSeqNo { get; set; }
        public string? ProcessCode { get; set; }
        public string? ProcessName { get; set; }
        public DateTime? StartPlanTime { get; set; }
        public DateTime? EndPlanTime { get; set; }
        public string? MachineNo { get; set; }
        public string? MachineName { get; set; }
        public DateTime? StartTime { get; set; }
        public string? StartOperatorId { get; set; }
        public string? StartOperatorName { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public int? InputQty { get; set; }
        public int? OutputQty { get; set; }
        public int? TotalDefectQty { get; set; }
        public string? ProductCateg { get; set; }
    }
}
