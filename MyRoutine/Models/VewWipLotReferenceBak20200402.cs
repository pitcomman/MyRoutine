using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewWipLotReferenceBak20200402
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public DateTime? StartPlanTime { get; set; }
        public DateTime? EndPlanTime { get; set; }
        public DateTime? StartTime { get; set; }
        public string? StartOperatorId { get; set; }
        public string? StartOperatorName { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public string LineGroupId { get; set; } = null!;
        public string? LineGroupName { get; set; }
        public string? LineId { get; set; }
        public string? LineName { get; set; }
        public int? InputQty { get; set; }
        public int? OutputQty { get; set; }
        public int? TotalDefectQty { get; set; }
        public int? CurrentQty { get; set; }
        public int? CurrentSubQty { get; set; }
        public string? Unit { get; set; }
        public string? UnitName { get; set; }
        public int UnitPrice { get; set; }
        public string Status { get; set; } = null!;
        public string? MachineNo { get; set; }
    }
}
