using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewInfoLotTrouble
    {
        public string MachineNo { get; set; } = null!;
        public string OpeGroupCode { get; set; } = null!;
        public string? OpeGroupName { get; set; }
        public DateTime StartTime { get; set; }
        public string StartOperatorId { get; set; } = null!;
        public string? StartOperatorName { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public int? StopMin { get; set; }
        public string? SupplementCateg { get; set; }
        public string? OperationCode { get; set; }
        public string? OperationName { get; set; }
        public string ItemCateg { get; set; } = null!;
        public string? ItemCategName { get; set; }
        public string ItemCode { get; set; } = null!;
        public string? ItemName { get; set; }
        public string? Result { get; set; }
        public string? Unit { get; set; }
    }
}
