using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class SupplementItemBefore20200101
    {
        public int SupplementId { get; set; }
        public string SupplementCateg { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public string OpeGroupCode { get; set; } = null!;
        public string? Ztcno { get; set; }
        public string? ZtcnoSuffix { get; set; }
        public DateTime KeyTime { get; set; }
        public string OperationCode { get; set; } = null!;
        public string? OperationName { get; set; }
        public DateTime StartTime { get; set; }
        public string StartOperatorId { get; set; } = null!;
        public string? StartOperatorName { get; set; }
        public DateTime EndTime { get; set; }
        public string EndOperatorId { get; set; } = null!;
        public string? EndOperatorName { get; set; }
        public string? FinalResult { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
