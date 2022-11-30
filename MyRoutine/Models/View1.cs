using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class View1
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public DateTime? StartTime { get; set; }
        public string DefectCode { get; set; } = null!;
        public string DefectName { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public string? MachineName { get; set; }
        public int DefectQty { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
    }
}
