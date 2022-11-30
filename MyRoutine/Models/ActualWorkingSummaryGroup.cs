using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ActualWorkingSummaryGroup
    {
        public string SummaryGroupCode { get; set; } = null!;
        public string SummaryGroupName { get; set; } = null!;
        public string OpeGroupCateg { get; set; } = null!;
        public string ActualWorkingType { get; set; } = null!;
        public int? AccumulationSeq { get; set; }
        public string? ParentSummaryGroupCode { get; set; }
        public string? ActualWorkingColor { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
