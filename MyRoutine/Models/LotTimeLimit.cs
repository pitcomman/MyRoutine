using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LotTimeLimit
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int FromProcessSeqNo { get; set; }
        public string FromProcessCode { get; set; } = null!;
        public string FromProcessName { get; set; } = null!;
        public string FromProcessSe { get; set; } = null!;
        public DateTime? FromResultTime { get; set; }
        public int ToProcessSeqNo { get; set; }
        public string ToProcessCode { get; set; } = null!;
        public string ToProcessName { get; set; } = null!;
        public string ToProcessSe { get; set; } = null!;
        public DateTime? ToLimitPlanTime { get; set; }
        public DateTime? ToResultTime { get; set; }
        public string Sign { get; set; } = null!;
        public int LimitMin { get; set; }
        public bool NoCheck { get; set; }
        public string AutoAndon { get; set; } = null!;
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
        public DateTime AddDate { get; set; }
    }
}
