using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LotInputControlTemp
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string? MachineGroup { get; set; }
        public int? ParentSeqNo { get; set; }
        public string? Fifogroup { get; set; }
        public long ChildSeqNo { get; set; }
        public string Fifocheck { get; set; } = null!;
        public string StartFlg { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
