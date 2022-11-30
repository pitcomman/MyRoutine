using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewMachineMonitoring
    {
        public string Line { get; set; } = null!;
        public string? Process { get; set; }
        public string MachineNo { get; set; } = null!;
        public string? ProcessingLot { get; set; }
        public string? Status { get; set; }
        public string? DeviceCheck { get; set; }
        public string? Material { get; set; }
        public string? Tool { get; set; }
        public string? Carrier { get; set; }
    }
}
