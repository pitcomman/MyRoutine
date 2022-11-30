using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Tact
    {
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public decimal TactTime { get; set; }
        public string TactBaseUnit { get; set; } = null!;
        public string? TimeCondition { get; set; }
        public string? Sign { get; set; }
        public decimal? Threshold { get; set; }
        public string? Abnormal { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
