using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ActualWorkingSnapShot202002
    {
        public DateTime ActualWorkingDate { get; set; }
        public string SummaryGroupCode { get; set; } = null!;
        public string SummaryGroupName { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public int SummaryTime { get; set; }
        public string ProductionStartTime { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
