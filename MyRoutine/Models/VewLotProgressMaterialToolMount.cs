using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewLotProgressMaterialToolMount
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string? MachineNo { get; set; }
        public string? MachineName { get; set; }
        public DateTime? LotStartTime { get; set; }
        public string? LotStartOperatorId { get; set; }
        public string? LotStartOperatorName { get; set; }
        public DateTime? LotEndTime { get; set; }
        public string? LotEndOperatorId { get; set; }
        public string? LotEndOperatorName { get; set; }
        public int? InputQty { get; set; }
        public int? OutputQty { get; set; }
        public int? TotalDefectQty { get; set; }
        public int? SurplusInQty { get; set; }
        public int? TotalBlendInQty { get; set; }
        public int? SurplusOutQty { get; set; }
        public int? TotalBlendOutQty { get; set; }
        public int? SampleQty { get; set; }
        public int? UnclearQty { get; set; }
        public int? SubInputQty { get; set; }
        public int? SubSurplusInQty { get; set; }
        public int? SubTotalBlendInQty { get; set; }
        public int? SubOutputQty { get; set; }
        public int? SubTotalDefectQty { get; set; }
        public int? SubSurplusOutQty { get; set; }
        public int? SubTotalBlendOutQty { get; set; }
        public int? SubSampleQty { get; set; }
        public int? SubUnclearQty { get; set; }
        public string InputUnit { get; set; } = null!;
        public string? InputUnitName { get; set; }
        public string OutputUnit { get; set; } = null!;
        public string? OutputUnitName { get; set; }
        public string? OpeGroupCode { get; set; }
        public string? OpeGroupName { get; set; }
        public int? MaterialToolFlag { get; set; }
        public string? MaterialToolDefectLotNo { get; set; }
        public string? MaterialToolDefectLotNoSuffix { get; set; }
        public string? MaterialToolDefectName { get; set; }
        public int? MaterialToolDefectQty { get; set; }
        public string? MaterialToolCateg { get; set; }
        public string? MaterialToolCategName { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public DateTime? MaterialToolStartTime { get; set; }
        public string? StartOperatorId { get; set; }
        public string? StartOperatorName { get; set; }
        public DateTime? MaterialToolEndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public DateTime? SortStartTime { get; set; }
        public DateTime? SortEndTime { get; set; }
        public DateTime? SortExpiredDate { get; set; }
    }
}
