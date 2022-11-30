using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewInfoLotTool
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public string? MachineName { get; set; }
        public string OpeGroupCode { get; set; } = null!;
        public string? OpeGroupName { get; set; }
        public string ToolLotNo { get; set; } = null!;
        public string ToolLotNoSuffix { get; set; } = null!;
        public string? ToolName { get; set; }
        public string? ToolCateg { get; set; }
        public string? ToolCategName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
