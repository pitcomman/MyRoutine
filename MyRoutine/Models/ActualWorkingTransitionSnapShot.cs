using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ActualWorkingTransitionSnapShot
    {
        public DateTime ActualWorkingDate { get; set; }
        public int SeriesDataIndex { get; set; }
        public string OpeGroupCateg { get; set; } = null!;
        public string SummaryGroupCode { get; set; } = null!;
        public string SummaryGroupName { get; set; } = null!;
        public string? ParentSummaryGroupCode { get; set; }
        public string MachineNo { get; set; } = null!;
        public int SummaryTime { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
