using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LotInfo
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public DateTime? EstimateOutputDate { get; set; }
        public DateTime? AnswerOutputDate { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
