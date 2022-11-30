using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewBlendLotInfo
    {
        public string LotNo { get; set; } = null!;
        public string? LotNoSuffix { get; set; }
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public DateTime? ExpireDate { get; set; }
        public int StockQty { get; set; }
        public string Status { get; set; } = null!;
    }
}
