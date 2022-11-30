using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LtprocessSnapShot
    {
        public string LineGroupId { get; set; } = null!;
        public string LineId { get; set; } = null!;
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public DateTime EndTime { get; set; }
        public int ProcessTime { get; set; }
        public int WaitTime { get; set; }
        public int OutputQty { get; set; }
        public bool LastProcess { get; set; }
        public string ProductCateg { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
