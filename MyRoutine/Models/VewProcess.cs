using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewProcess
    {
        public string DispProcessCode { get; set; } = null!;
        public string? DispProcessName { get; set; }
        public string? ProcessName { get; set; }
        public string? Remarks { get; set; }
        public string ProcessGroup { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public int? OrderSeqNo { get; set; }
        public int SortNo { get; set; }
    }
}
