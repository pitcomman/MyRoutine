using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewLeadTimeSec
    {
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string LineGroupId { get; set; } = null!;
        public string LineId { get; set; } = null!;
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int? LeadTimeSec { get; set; }
        public int? StopTimeSec { get; set; }
        public int? ProductTimeSec { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? BaseTime { get; set; }
    }
}
