using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class MachineMaintenance
    {
        public string MachineNo { get; set; } = null!;
        public string? MachineName { get; set; }
        public string OpeGroupCode { get; set; } = null!;
        public string? OpeGroupName { get; set; }
        public DateTime StartTime { get; set; }
        public string StartOperatorId { get; set; } = null!;
        public string? StartOperatorName { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public string? MaintenanceReason { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
