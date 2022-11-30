using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewPrdEndProcess
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public bool ProductEnd { get; set; }
    }
}
