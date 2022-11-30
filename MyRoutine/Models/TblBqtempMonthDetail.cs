using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TblBqtempMonthDetail
    {
        public string Date8 { get; set; } = null!;
        public string Opid { get; set; } = null!;
        public string? Class { get; set; }
        public string? Per { get; set; }
        public string BqCode { get; set; } = null!;
        public string Catege { get; set; } = null!;
        public decimal? NeedTime { get; set; }
        public string MachineNo { get; set; } = null!;
        public string MachineName { get; set; } = null!;
        public string OpeGroupName { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string? MaintenanceReason { get; set; }
    }
}
