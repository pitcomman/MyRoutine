using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class SmallProcProgress
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public int SmallProcessSeqNo { get; set; }
        public string SmallProcessCode { get; set; } = null!;
        public string? SmallProcessName { get; set; }
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
        public string? OutputName1 { get; set; }
        public int? OutputQty1 { get; set; }
        public string? OutputName2 { get; set; }
        public int? OutputQty2 { get; set; }
        public int? TotalDefectQty { get; set; }
        public bool OptionalProcess { get; set; }
        public bool QtyCheck { get; set; }
        public bool DeletePermission { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
