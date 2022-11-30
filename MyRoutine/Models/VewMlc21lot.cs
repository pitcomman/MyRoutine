using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewMlc21lot
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductFamily { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public int CurrentQty { get; set; }
        public int InputQty { get; set; }
        public int OutputQty { get; set; }
        public DateTime InputDate { get; set; }
        public DateTime OutputDate { get; set; }
        public string OrderNo { get; set; } = null!;
        public string Mlc21statusCode { get; set; } = null!;
        public string? Mlc21process { get; set; }
    }
}
