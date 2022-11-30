using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TblMachineRunList
    {
        public string LineId { get; set; } = null!;
        public string Process { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public int? Status { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
