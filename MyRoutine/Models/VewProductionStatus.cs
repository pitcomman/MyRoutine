using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewProductionStatus
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public string? OrderNo { get; set; }
        public int ProcessSeqNo { get; set; }
        public int DetailSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string? MachineNo { get; set; }
        public string? MachineName { get; set; }
        public string? LineId { get; set; }
        public string LineGroupId { get; set; } = null!;
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? ResultOutUnitLot { get; set; }
        public decimal? ResultOutUnitPunit { get; set; }
        public decimal? ResultRsltUnitLot { get; set; }
        public int? ResultRsltUnitPunit { get; set; }
    }
}
