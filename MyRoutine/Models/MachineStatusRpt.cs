using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class MachineStatusRpt
    {
        public string ProcessCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public string StatusCode { get; set; } = null!;
        public DateTime StatusChangeTime { get; set; }
        public string? LotNo { get; set; }
        public string? LotNoSuffix { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
