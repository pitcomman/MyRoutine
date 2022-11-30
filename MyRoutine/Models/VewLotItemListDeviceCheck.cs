using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewLotItemListDeviceCheck
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string? MachineNo { get; set; }
        public int ProcessSeqNo { get; set; }
        public int SmallProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string? OpeGroupCode { get; set; }
        public string? OpeGroupName { get; set; }
        public string OperationCode { get; set; } = null!;
        public string? OperationName { get; set; }
        public DateTime StartTime { get; set; }
        public string StartOperatorId { get; set; } = null!;
        public string? StartOperatorName { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public string? FinalResult { get; set; }
        public string OpeItemCategFlag { get; set; } = null!;
        public int DetailSeqNo { get; set; }
        public string SearchType { get; set; } = null!;
        public string SearchProductCode { get; set; } = null!;
        public string FlagSplitLot { get; set; } = null!;
    }
}
