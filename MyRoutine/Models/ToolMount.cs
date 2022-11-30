using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ToolMount
    {
        public string MachineNo { get; set; } = null!;
        public string? MachineName { get; set; }
        public string OpeGroupCode { get; set; } = null!;
        public string? OpeGroupName { get; set; }
        public string ToolLotNo { get; set; } = null!;
        public string? ToolName { get; set; }
        public string? ToolCateg { get; set; }
        public string? ToolCategName { get; set; }
        public DateTime StartTime { get; set; }
        public string StartOperatorId { get; set; } = null!;
        public string? StartOperatorName { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public DateTime? CheckTime { get; set; }
        public string? CheckOperatorId { get; set; }
        public string? CheckOperatorName { get; set; }
        public string? StartShotCount { get; set; }
        public string? EndShotCount { get; set; }
        public string? SlotNo { get; set; }
        public string ProductChange { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
