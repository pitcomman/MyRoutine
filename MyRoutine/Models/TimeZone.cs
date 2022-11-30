using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TimeZone
    {
        public string TimeZoneCode { get; set; } = null!;
        public string TimeZoneName { get; set; } = null!;
        public string TimeZoneCateg { get; set; } = null!;
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public int StandardDateDiff { get; set; }
        public int OrderSeqNo { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
