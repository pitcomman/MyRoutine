using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class AbnormalSerialTran
    {
        public int TranId { get; set; }
        public string SerialNo { get; set; } = null!;
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int AbnormalNo { get; set; }
        public string? AbnormalCode { get; set; }
        public string? AbnormalReason { get; set; }
        public string? ProcessCode { get; set; }
        public string StatusCode { get; set; } = null!;
        public int? AutoAndonTranId { get; set; }
        public string? Ipaddress { get; set; }
        public DateTime OperationDate { get; set; }
        public string OperatorId { get; set; } = null!;
        public int? StopProcessSeqNo { get; set; }
        public string CarrierNo { get; set; } = null!;
        public string? Remarks { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
