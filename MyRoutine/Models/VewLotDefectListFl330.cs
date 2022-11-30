using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewLotDefectListFl330
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string DetailSeqNo { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string? MachineNo { get; set; }
        public DateTime? StartTime { get; set; }
        public string? StartOperatorId { get; set; }
        public string? StartOperatorName { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public string WaitTime { get; set; } = null!;
        public string ProcessTime { get; set; } = null!;
        public string TactTime { get; set; } = null!;
        public int? InputQty { get; set; }
        public int? SurplusInQty { get; set; }
        public int? OutputQty { get; set; }
        public int? TotalDefectQty { get; set; }
        public string DefectiveRate { get; set; } = null!;
        public int? SurplusOutQty { get; set; }
        public int? SampleQty { get; set; }
        public int? H { get; set; }
        public int? Dc { get; set; }
        public int? Hfe { get; set; }
        public int? Mold { get; set; }
        public int? Bari { get; set; }
        public int? Other { get; set; }
        public int? Forming { get; set; }
        public int? Package { get; set; }
        public int? InTape { get; set; }
        public int? Machine { get; set; }
        public int? Material { get; set; }
        public int? Sample { get; set; }
        public int? Laser { get; set; }
        public int? Mark { get; set; }
        public int? MoldBs { get; set; }
        public int? OtherB { get; set; }
        public int? ChipH { get; set; }
        public int? ChipDc { get; set; }
        public int? ChipHFe { get; set; }
        public int? Lownoise { get; set; }
        public int? Sus1 { get; set; }
        public int? Sus2 { get; set; }
        public int? SurF { get; set; }
        public int? SurR { get; set; }
        public int? Os1 { get; set; }
        public int? Os2 { get; set; }
        public int? Unclear { get; set; }
    }
}
