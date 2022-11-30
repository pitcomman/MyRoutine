using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewReferenceLot
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public string ProductCategName { get; set; } = null!;
        public string? OrderNo { get; set; }
        public int ProcessSeqNo { get; set; }
        public int DetailSeqNo { get; set; }
        public int SmallProcessSeqNo { get; set; }
        public string LineGroupId { get; set; } = null!;
        public string? LineId { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string? MachineNo { get; set; }
        public DateTime? StartTime { get; set; }
        public string? StartOperatorId { get; set; }
        public string? StartOperatorName { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public int? WaitTime { get; set; }
        public int? ProcessTime { get; set; }
        public decimal? TactTime { get; set; }
        public int? InputQty { get; set; }
        public int? SubInputQty { get; set; }
        public int? SurplusInQty { get; set; }
        public int? SubSurplusInQty { get; set; }
        public int? TotalBlendIn { get; set; }
        public int? SubTotalBlendInQty { get; set; }
        public string InputUnit { get; set; } = null!;
        public string? InputUnitName { get; set; }
        public string? OutputName1 { get; set; }
        public int? OutputQty1 { get; set; }
        public int? SubOutputQty { get; set; }
        public string? OutputName2 { get; set; }
        public int? OutputQty2 { get; set; }
        public int? TotalDefect { get; set; }
        public int? SubTotalDefectQty { get; set; }
        public int? SurplusOutQty { get; set; }
        public int? SubSurplusOutQty { get; set; }
        public int? TotalBlendOut { get; set; }
        public int? SubTotalBlendOutQty { get; set; }
        public int? SampleQty { get; set; }
        public int? SubSampleQty { get; set; }
        public int? UnclearQty { get; set; }
        public int? SubUnclearQty { get; set; }
        public string OutputUnit { get; set; } = null!;
        public string? OutputUnitName { get; set; }
        public double? DefectiveRate { get; set; }
        public string SearchType { get; set; } = null!;
        public string SearchProductCode { get; set; } = null!;
        public string FlagSplitLot { get; set; } = null!;
        public string ProgressData { get; set; } = null!;
    }
}
