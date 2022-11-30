using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class MachineAlarmRpt
    {
        public string ProcessCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public string AlarmCode { get; set; } = null!;
        public string AlarmMessage { get; set; } = null!;
        public DateTime AlarmTime { get; set; }
        public string? LotNo { get; set; }
        public string? LotNoSuffix { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
