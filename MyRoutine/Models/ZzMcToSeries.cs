using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZzMcToSeries
    {
        public string MachineNo { get; set; } = null!;
        public string? MachineName { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
    }
}
