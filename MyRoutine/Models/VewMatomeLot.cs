using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewMatomeLot
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string ParentLotNo { get; set; } = null!;
        public string ParentLotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductFamily { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public string? OrderNo { get; set; }
    }
}
