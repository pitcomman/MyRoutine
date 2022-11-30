using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class SmallProcLotDefect
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public int SmallProcessSeqNo { get; set; }
        public string DefectCode { get; set; } = null!;
        public string DefectName { get; set; } = null!;
        public int DefectQty { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
