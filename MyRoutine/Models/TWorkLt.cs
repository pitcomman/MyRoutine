using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TWorkLt
    {
        public string? LineGroupId { get; set; }
        public string? LineId { get; set; }
        public string? LotNo { get; set; }
        public string? LotNoSuffix { get; set; }
        public string? Type { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductCateg { get; set; }
        public int? ProcessSeqNo { get; set; }
        public string? ProcessCode { get; set; }
        public string? ProcessName { get; set; }
        public string? MachineNo { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? ProcessTime { get; set; }
        public int? WaitTime { get; set; }
        public int? OutputQty { get; set; }
        public bool? LastProcess { get; set; }
        public DateTime? EndDate { get; set; }
        public int? BaseTime { get; set; }
    }
}
