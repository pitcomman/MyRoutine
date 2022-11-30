using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class DisplayDetailSearchInfo
    {
        public string OperatorId { get; set; } = null!;
        public string SettingName { get; set; } = null!;
        public int FormNo { get; set; }
        public string ControlId { get; set; } = null!;
        public string SearchInfoValue { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
