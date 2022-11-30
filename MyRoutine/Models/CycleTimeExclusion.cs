using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class CycleTimeExclusion
    {
        public int CycleTimeExclusionId { get; set; }
        public string OpeGroupCode { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
