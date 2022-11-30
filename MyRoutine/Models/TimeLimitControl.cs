using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TimeLimitControl
    {
        public string FlowId { get; set; } = null!;
        public int FromProcessSeqNo { get; set; }
        public string FromProcessSe { get; set; } = null!;
        public int ToProcessSeqNo { get; set; }
        public string ToProcessSe { get; set; } = null!;
        public string Sign { get; set; } = null!;
        public int LimitMin { get; set; }
        public string AutoAndon { get; set; } = null!;
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
        public DateTime AddDate { get; set; }
    }
}
