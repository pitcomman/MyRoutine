using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewZchart
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductFamily { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public string ResultCateg { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string? MachineNo { get; set; }
        public DateTime? ResultTime { get; set; }
        public int? ResultQty { get; set; }
        public string OrderNo { get; set; } = null!;
    }
}
