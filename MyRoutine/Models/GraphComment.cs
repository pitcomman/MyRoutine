using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class GraphComment
    {
        public int ComId { get; set; }
        public string GraphObjName { get; set; } = null!;
        public string GraphName { get; set; } = null!;
        public string MonitoringGroup { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public string? LineId { get; set; }
        public string? ProductCode { get; set; }
        public string? MachineNo { get; set; }
        public string PeriodCateg { get; set; } = null!;
        public string ComYear { get; set; } = null!;
        public string ComMonth { get; set; } = null!;
        public string? ComWeek { get; set; }
        public string? ComDay { get; set; }
        public string? ComHour { get; set; }
        public string OperatorId { get; set; } = null!;
        public string OperatorName { get; set; } = null!;
        public string Comments { get; set; } = null!;
        public bool ShowScrollComment { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
