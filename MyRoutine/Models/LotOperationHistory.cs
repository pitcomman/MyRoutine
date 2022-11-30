using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LotOperationHistory
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string OperationCode { get; set; } = null!;
        public string? OperationName { get; set; }
        public DateTime StartTime { get; set; }
        public string StartOperatorId { get; set; } = null!;
        public string? StartOperatorName { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public string? FinalResult { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
