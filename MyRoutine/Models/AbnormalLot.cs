using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class AbnormalLot
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int AbnormalNo { get; set; }
        public string AbnormalCode { get; set; } = null!;
        public string? AbnormalName { get; set; }
        public string? AbnormalReason { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public DateTime RegistDate { get; set; }
        public string RegistOperatorId { get; set; } = null!;
        public string? RegistOperatorName { get; set; }
        public string RegistComputerName { get; set; } = null!;
        public DateTime? LatestUpdDate { get; set; }
        public string LatestUpdOperatorId { get; set; } = null!;
        public string? LatestUpdOperatorName { get; set; }
        public string LatestComputerName { get; set; } = null!;
        public string StatusCode { get; set; } = null!;
        public string? StatusName { get; set; }
        public int? StopProcessSeqNo { get; set; }
        public int? AutoAndonTranId { get; set; }
        public string? Ipaddress { get; set; }
        public string? Remark { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
