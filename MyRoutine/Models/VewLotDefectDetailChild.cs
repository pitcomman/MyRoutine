using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewLotDefectDetailChild
    {
        public string? LineId { get; set; }
        public string? LineName { get; set; }
        public string LineGroupId { get; set; } = null!;
        public string? FirstMachineNo { get; set; }
        public int? FirstInputQty { get; set; }
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string? MachineNo { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? InputQty { get; set; }
        public int? OutputQty { get; set; }
        public string? DefectGroupCode { get; set; }
        public string? DefectGroupName { get; set; }
        public string DefectCode { get; set; } = null!;
        public string DefectName { get; set; } = null!;
        public int ProcessDefectQty { get; set; }
        public int DefectQty { get; set; }
        public string ProductCateg { get; set; } = null!;
        public int? Countday { get; set; }
        public string? Countday2 { get; set; }
        public int? Countmonth { get; set; }
    }
}
