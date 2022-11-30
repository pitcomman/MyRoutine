using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class OperationGroupTemp
    {
        public string OpeGroupCode { get; set; } = null!;
        public string? OpeGroupName { get; set; }
        public string OpeGroupCateg { get; set; } = null!;
        public string? MaterialCateg { get; set; }
        public string? ActualWorkingGraph { get; set; }
        public bool NegativeActualWorking { get; set; }
        public string? ActualWorkingColor { get; set; }
        public bool? Collation { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
