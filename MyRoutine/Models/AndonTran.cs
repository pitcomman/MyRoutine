using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class AndonTran
    {
        public int TranId { get; set; }
        public DateTime AndonTime { get; set; }
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string MachineNo { get; set; } = null!;
        public string? MachineName { get; set; }
        public string ConditionNo { get; set; } = null!;
        public string DefectCode { get; set; } = null!;
        public string? DefectName { get; set; }
        public string DefectCondition { get; set; } = null!;
        public string? PopulationParam { get; set; }
        public string Sign { get; set; } = null!;
        public decimal Threshold { get; set; }
        public int? ActualPopulationParamQty { get; set; }
        public int ActualDefectQty { get; set; }
        public decimal? ActualDefectRate { get; set; }
        public string? AbnormalCode { get; set; }
        public int? AbnormalNo { get; set; }
        public DateTime? CheckStartTime { get; set; }
        public string? CheckStartOperatorId { get; set; }
        public string? CheckStartOperatorName { get; set; }
        public DateTime? CheckEndTime { get; set; }
        public string? CheckEndOperatorId { get; set; }
        public string? CheckEndOperatorName { get; set; }
        public string? AndonCommt { get; set; }
        public string? DocumentPath { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
