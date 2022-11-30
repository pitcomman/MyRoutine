using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewLotSplitHistory
    {
        public int SeqNo { get; set; }
        public bool IsParent { get; set; }
        public string LotNo { get; set; } = null!;
        public string LotNoSub { get; set; } = null!;
        public string? PLotNoSub { get; set; }
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string LotSplitProcess { get; set; } = null!;
    }
}
