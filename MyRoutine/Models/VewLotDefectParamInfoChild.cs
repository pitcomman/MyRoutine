using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewLotDefectParamInfoChild
    {
        public string? LineId { get; set; }
        public string? LineName { get; set; }
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public int DetailSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string? MachineNo { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string ProductCateg { get; set; } = null!;
        public int? DefectParam { get; set; }
        public int? Countday { get; set; }
        public string? Countday2 { get; set; }
        public int? Countmonth { get; set; }
        public string LineGroupId { get; set; } = null!;
        public string? ProductGroup { get; set; }
        public string? StartOperatorId { get; set; }
        public string? StartOperatorName { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public int? Countyear { get; set; }
        public string? Countymd { get; set; }
        public string? Countym { get; set; }
        public string WeekMark { get; set; } = null!;
    }
}
