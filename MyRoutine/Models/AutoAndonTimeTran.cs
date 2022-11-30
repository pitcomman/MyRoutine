using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class AutoAndonTimeTran
    {
        public int TranId { get; set; }
        public string ControlType { get; set; } = null!;
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
        public string TimeCondition { get; set; } = null!;
        public string Sign { get; set; } = null!;
        public decimal Threshold { get; set; }
        public int FromProcessSeqNo { get; set; }
        public string FromProcessCode { get; set; } = null!;
        public string? FromProcessName { get; set; }
        public string FromProcessSe { get; set; } = null!;
        public DateTime FromResultTime { get; set; }
        public int ToProcessSeqNo { get; set; }
        public string ToProcessCode { get; set; } = null!;
        public string? ToProcessName { get; set; }
        public string ToProcessSe { get; set; } = null!;
        public DateTime ToResultTime { get; set; }
        public decimal? TactTime { get; set; }
        public decimal ActualTime { get; set; }
        public decimal? DifferenceTime { get; set; }
        public decimal? DifferenceRate { get; set; }
        public string? AbnormalCode { get; set; }
        public int? AbnormalNo { get; set; }
        public string MachineStop { get; set; } = null!;
        public string AndonRegister { get; set; } = null!;
        public DateTime? CheckStartTime { get; set; }
        public string? CheckStartOperatorId { get; set; }
        public string? CheckStartOperatorName { get; set; }
        public DateTime? CheckEndTime { get; set; }
        public string? CheckEndOperatorId { get; set; }
        public string? CheckEndOperatorName { get; set; }
        public string? AndonCommt { get; set; }
        public string? DocumentPath { get; set; }
        public string? CommentRank { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
