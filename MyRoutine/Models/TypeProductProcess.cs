using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TypeProductProcess
    {
        public string Type { get; set; } = null!;
        public bool TypeGroupFlag { get; set; }
        public string ProductCode { get; set; } = null!;
        public bool ProductGroupFlag { get; set; }
        public string ProcessCode { get; set; } = null!;
        public bool ProcessGroupFlag { get; set; }
        public string? ProcessName { get; set; }
        public int OrderSeqNo { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
