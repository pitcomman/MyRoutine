using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewWiplotSummary
    {
        public string LineGroupId { get; set; } = null!;
        public string LineId { get; set; } = null!;
        public string? LineName { get; set; }
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string ProcessCategory { get; set; } = null!;
        public int WiplotCount { get; set; }
        public int? LotCount { get; set; }
    }
}
