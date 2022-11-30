using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ActualWorkingSummaryCondition
    {
        public int ActualWorkingConditionId { get; set; }
        public string SummaryGroupCode { get; set; } = null!;
        public string OperationGroupMode { get; set; } = null!;
        public string? OperationGroup { get; set; }
        public string? StartOperationGroup { get; set; }
        public string? StartEndFlagS { get; set; }
        public string? EndOperationGroup { get; set; }
        public string? StartEndFlagE { get; set; }
        public string? IncludeOperationGroup { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
