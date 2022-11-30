using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class NcimRemoteControl
    {
        public string Eqpifcode { get; set; } = null!;
        public string RequestCategory { get; set; } = null!;
        public string WipFlag { get; set; } = null!;
        public string ProcessingResult { get; set; } = null!;
        public byte ControlSignal { get; set; }
        public string WipsendFlag { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
