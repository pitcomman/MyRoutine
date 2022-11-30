using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ProcessArrange
    {
        public string ProcessCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public bool IsParentMachine { get; set; }
        public string SlotNo { get; set; } = null!;
        public string ArrangeOpeCode { get; set; } = null!;
        public string OpeGroupCode { get; set; } = null!;
        public string InputOption { get; set; } = null!;
        public string DisplayOption { get; set; } = null!;
        public int DisplaySeq { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
