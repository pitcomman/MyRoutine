using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class AndonCondition20190522
    {
        public string ConditionNo { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public string DefectCode { get; set; } = null!;
        public string DefectCondition { get; set; } = null!;
        public string? PopulationParam { get; set; }
        public string Sign { get; set; } = null!;
        public decimal Threshold { get; set; }
        public string? AbnormalCode { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
