using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class NcimToEqpif
    {
        public string Eqpifcode { get; set; } = null!;
        public string? ServerResponse { get; set; }
        public string? RemoteControl { get; set; }
        public string? WorkInProcess { get; set; }
        public string? CarrierSetTrans { get; set; }
        public string? MaterialSetTrans { get; set; }
        public string? ToolSetTrans { get; set; }
        public string? Remarks { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
