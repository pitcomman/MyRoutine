using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class OperationTact
    {
        public string OpeGroupCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public int TactTime { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
