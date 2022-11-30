using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewTenkenMaintenance
    {
        public string? ParentMachineNo { get; set; }
        public string MachineNo { get; set; } = null!;
        public string OpeGroupCode { get; set; } = null!;
        public string? OpeGroupName { get; set; }
        public DateTime? Endtime { get; set; }
    }
}
