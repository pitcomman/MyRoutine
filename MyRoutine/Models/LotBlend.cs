using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LotBlend
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string BlendLotNo { get; set; } = null!;
        public string BlendLotNoSuffix { get; set; } = null!;
        public string BlendCateg { get; set; } = null!;
        public string BlendInOut { get; set; } = null!;
        public int BlendQty { get; set; }
        public int SubBlendQty { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
