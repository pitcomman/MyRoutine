using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LotAlarm
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string AlarmCategory { get; set; } = null!;
        public string AlarmName { get; set; } = null!;
        public int AlarmCount { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
