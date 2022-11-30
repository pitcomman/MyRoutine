using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewLotStopLine
    {
        public string? AbnormalName { get; set; }
        public string? ProcessName { get; set; }
        public string LotNo { get; set; } = null!;
        public string? LotNoSuffix { get; set; }
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public DateTime? CompleteDate { get; set; }
        public string? MachineNo { get; set; }
        public string? LineId { get; set; }
        public string? LineName { get; set; }
        public string LineGroupId { get; set; } = null!;
        public string? LineGroupName { get; set; }
        public DateTime? RegistDate { get; set; }
        public string? RegistOperatorId { get; set; }
        public string? RegistOperatorName { get; set; }
        public string? AbnormalReason { get; set; }
    }
}
