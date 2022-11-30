using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class AutoAndonPmstran
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
        public string MonitorName { get; set; } = null!;
        public string ItemName { get; set; } = null!;
        public string CalParamName { get; set; } = null!;
        public double CalResult { get; set; }
        public bool Judgement { get; set; }
        public string JudgementDetail { get; set; } = null!;
        public decimal Usl { get; set; }
        public decimal Lsl { get; set; }
        public decimal Uacl { get; set; }
        public decimal Lacl { get; set; }
        public string? GraphUrl { get; set; }
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
