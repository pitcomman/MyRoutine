using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class CurrentLoadCarrierInfo
    {
        public string CarrierNo { get; set; } = null!;
        public string CarrierName { get; set; } = null!;
        public string CarrierCateg { get; set; } = null!;
        public string? CarrierCategName { get; set; }
        public string OpeGroupCode { get; set; } = null!;
        public string? OpeGroupName { get; set; }
        public int SetCounter { get; set; }
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
