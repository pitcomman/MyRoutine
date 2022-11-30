using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZzzCheckLinegrouidIsnull
    {
        public string? LineGroupId { get; set; }
        public string? LineId { get; set; }
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string? MachineNo { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? ProcessTime { get; set; }
        public int? WaitTime { get; set; }
        public int? OutputQty { get; set; }
        public bool LastProcess { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? BaseTime { get; set; }
    }
}
