using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LotZtcinstructionWkTemp
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string Ztccateg { get; set; } = null!;
        public string Ztcno { get; set; } = null!;
        public string ZtcnoSuffix { get; set; } = null!;
        public string Ztcname { get; set; } = null!;
        public bool DisableFlag { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
