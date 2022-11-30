using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class RpmImport
    {
        public string RohmPackage { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public int Rpm { get; set; }
    }
}
