using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class MachineProcess
    {
        public string MachineNo { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
