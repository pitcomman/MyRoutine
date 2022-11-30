using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewAndonHistory
    {
        public string NcnstatusCode { get; set; } = null!;
        public DateTime AndonDate { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public int? TreatmentTime { get; set; }
        public string? Attender { get; set; }
        public string? Operator { get; set; }
        public string? MachineNo { get; set; }
        public string? Subject { get; set; }
        public string? ProcessCode { get; set; }
        public string? Process { get; set; }
        public string? Section { get; set; }
        public long SeqNo { get; set; }
        public string Ipaddress { get; set; } = null!;
        public string? TerminalName { get; set; }
        public string? TerminalType { get; set; }
        public string? TerminalTypeName { get; set; }
        public string? PlaceOfUse { get; set; }
        public string? OperatorId { get; set; }
        public string? OperatorName { get; set; }
        public string? MachineName { get; set; }
        public string? Memo { get; set; }
        public long? Ncnseq { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
        public string? Qcattender { get; set; }
        public string? EngineerAttender { get; set; }
        public string? AndonClassification { get; set; }
    }
}
