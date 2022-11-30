using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LotCompleteHist
    {
        public int TransId { get; set; }
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int CompleteQty { get; set; }
        public DateTime CompleteDate { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
