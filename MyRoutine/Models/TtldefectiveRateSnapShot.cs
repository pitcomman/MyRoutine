using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TtldefectiveRateSnapShot
    {
        public string LineGroupId { get; set; } = null!;
        public string LineId { get; set; } = null!;
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int? InputQty { get; set; }
        public int? OutputQty { get; set; }
        public int? TotalDefectQty { get; set; }
        public int? ScrapTotalDefectQty { get; set; }
        public int? FirstInputQty { get; set; }
        public int? LastDefectQty { get; set; }
        public int? ScrapLastDefectQty { get; set; }
        public DateTime? LastProcessEndTime { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
