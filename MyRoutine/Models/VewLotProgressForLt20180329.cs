using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewLotProgressForLt20180329
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
        public string? LineId { get; set; }
        public string? LineName { get; set; }
        public string? MachineNo { get; set; }
        public string? MachineName { get; set; }
        public DateTime? StartTime { get; set; }
        public string? StartOperatorId { get; set; }
        public string? StartOperatorName { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public int? InputQty { get; set; }
        public int? SurplusInQty { get; set; }
        public int? TotalBlendInQty { get; set; }
        public int? OutputQty { get; set; }
        public int? TotalDefectQty { get; set; }
        public int? SurplusOutQty { get; set; }
        public int? TotalBlendOutQty { get; set; }
        public int? SampleQty { get; set; }
        public int? UnclearQty { get; set; }
        public int LastProcess { get; set; }
    }
}
