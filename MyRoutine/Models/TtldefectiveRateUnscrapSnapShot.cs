using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TtldefectiveRateUnscrapSnapShot
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ScrapProcessSeqNo { get; set; }
        public string ScrapProcessCode { get; set; } = null!;
        public string ScrapProcessName { get; set; } = null!;
        public string ScrapDefectCode { get; set; } = null!;
        public string ScrapDefectName { get; set; } = null!;
        public int ScrapDefectQty { get; set; }
        public int UnScrapProcessSeqNo { get; set; }
        public string UnScrapProcessCode { get; set; } = null!;
        public string UnScrapProcessName { get; set; } = null!;
        public string UnScrapDefectCode { get; set; } = null!;
        public string UnScrapDefectName { get; set; } = null!;
        public int UnScrapDefectQty { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
