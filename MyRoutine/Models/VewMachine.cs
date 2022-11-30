using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewMachine
    {
        public string MachineNo { get; set; } = null!;
        public string? MachineName { get; set; }
        public string StatusCode { get; set; } = null!;
        public string? ParentMachineNo { get; set; }
        public int ChildExists { get; set; }
        public int MachineType { get; set; }
    }
}
