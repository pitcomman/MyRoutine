using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class DisplayHeader
    {
        public string OperatorId { get; set; } = null!;
        public string SettingName { get; set; } = null!;
        public string Pattern { get; set; } = null!;
        public int ResolutionW { get; set; }
        public int ResolutionH { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
