using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class WipsnapShot
    {
        public DateTime SnapShotDate { get; set; }
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string LineId { get; set; } = null!;
        public string? LineName { get; set; }
        public int WiplotCount { get; set; }
        public int? Wipqty { get; set; }
        public string? Wipunit { get; set; }
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public int MonitorProcessSeqNo { get; set; }
        public string MonitorProcessCode { get; set; } = null!;
        public string? MonitorProcessName { get; set; }
        public string? MonitorProcessCategory { get; set; }
        public string? MachineNo { get; set; }
        public string? MachineName { get; set; }
        public DateTime? StartTime { get; set; }
        public string? StartOperatorId { get; set; }
        public string? StartOperatorName { get; set; }
        public int Qty { get; set; }
        public string LotStatus { get; set; } = null!;
        public string? ProductCateg { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
