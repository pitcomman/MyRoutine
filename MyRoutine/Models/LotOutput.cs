using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LotOutput
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string OutputCode { get; set; } = null!;
        public string OutputName { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public int OutputQty { get; set; }
        public int SubOutputQty { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
