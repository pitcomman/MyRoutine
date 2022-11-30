using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Process
    {
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string ProcessCategory { get; set; } = null!;
        public string ProcessKind { get; set; } = null!;
        public bool SmallProcessFlag { get; set; }
        public string? Mow21processNo { get; set; }
        public string? Mlc21process { get; set; }
        public string? CostProcessCode { get; set; }
        public string? ProcessRangeCode { get; set; }
        public string? ProcessRangeName { get; set; }
        public string? Remarks { get; set; }
        public int OrderSeqNo { get; set; }
        public string InputUnit { get; set; } = null!;
        public string OutputUnit { get; set; } = null!;
        public int InventoryDiffDay { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
