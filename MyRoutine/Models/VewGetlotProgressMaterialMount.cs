using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewGetlotProgressMaterialMount
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string MaterialLotNo { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string? MachineNo { get; set; }
        public DateTime? StartTime { get; set; }
        public string? StartOperatorId { get; set; }
        public string? StartOperatorName { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public int? InputQty { get; set; }
        public string? InputUnitName { get; set; }
        public int? OutputQty { get; set; }
        public int? TotalDefectQty { get; set; }
        public string? OutputUnitName { get; set; }
        public int? SubTotalDefectQty { get; set; }
    }
}
