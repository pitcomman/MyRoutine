using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class AutoAndonDefectCondition
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
        public string Abnormal { get; set; } = null!;
        public string MachineStop { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
