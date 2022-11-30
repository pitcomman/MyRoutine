using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TblBqtempDailyDetail
    {
        public string Opid { get; set; } = null!;
        public string? Per { get; set; }
        public string? BqCode { get; set; }
        public string Catege { get; set; } = null!;
        public decimal? NeedTime { get; set; }
        public string? MachineNo { get; set; }
        public string? MachineName { get; set; }
        public string? OpeGroupName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? MaintenanceReason { get; set; }
    }
}
