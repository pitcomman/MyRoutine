using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewAlllotProgress
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductFamily { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
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
        public bool HavingSmallProcess { get; set; }
        public string? SmallProcessCode { get; set; }
        public int? SmallProcessSeqNo { get; set; }
        public string? SmallProcessName { get; set; }
        public string? SMachineNo { get; set; }
        public string? SMachineName { get; set; }
        public DateTime? SStartTime { get; set; }
        public string? SStartOperatorId { get; set; }
        public string? SStartOperatorName { get; set; }
        public DateTime? SEndTime { get; set; }
        public string? SEndOperatorId { get; set; }
        public string? SEndOperatorName { get; set; }
        public int? SInputQty { get; set; }
        public string? OutputName1 { get; set; }
        public int? OutputQty1 { get; set; }
        public string? OutputName2 { get; set; }
        public int? OutputQty2 { get; set; }
        public int? STotalDefectQty { get; set; }
    }
}
