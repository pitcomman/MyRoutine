using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LotDefectDetail
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public int DetailSeqNo { get; set; }
        public string DefectCode { get; set; } = null!;
        public string DefectName { get; set; } = null!;
        public int DefectQty { get; set; }
        public int SubDefectQty { get; set; }
        public string BlendLotNo { get; set; } = null!;
        public string BlendLotNoSuffix { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
