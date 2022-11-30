using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class OperationCycleTran
    {
        public string OperationCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public DateTime? OperationTime { get; set; }
        public int CycleCount { get; set; }
        public int OperationCount1 { get; set; }
        public int OperationCount2 { get; set; }
        public int OperationCount3 { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
