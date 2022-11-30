using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewLotOperationItemCheck
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string? MachineName { get; set; }
        public string OperationCode { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public string ItemCateg { get; set; } = null!;
        public string? ItemCategName { get; set; }
        public string ItemCode { get; set; } = null!;
        public string? ItemName { get; set; }
        public string? Result { get; set; }
    }
}
