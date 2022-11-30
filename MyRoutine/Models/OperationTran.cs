using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class OperationTran
    {
        public int TranId { get; set; }
        public string MachineNo { get; set; } = null!;
        public string OperationCode { get; set; } = null!;
        public string? LotNo { get; set; }
        public string? LotNoSuffix { get; set; }
        public DateTime OperationTime { get; set; }
        public string OperatorId { get; set; } = null!;
        public string UpdateCateg { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
