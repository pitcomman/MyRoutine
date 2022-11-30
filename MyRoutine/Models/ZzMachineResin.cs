using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZzMachineResin
    {
        public string? Process { get; set; }
        public string MachineNo { get; set; } = null!;
        public string? OpeGroup { get; set; }
        public string MaterialLotNo { get; set; } = null!;
        public string MaterialLotNoSuffix { get; set; } = null!;
        public string? MaterialName { get; set; }
        public string? MaterialSpec { get; set; }
        public string? MaterialCateg { get; set; }
        public string? ExpiredDate { get; set; }
        public string? StartTime { get; set; }
        public string? StartOperator { get; set; }
        public string? EndTime { get; set; }
        public string? EndOperator { get; set; }
        public DateTime SortStartTime { get; set; }
        public DateTime? SortEndTime { get; set; }
        public DateTime? SortExpiredDate { get; set; }
        public string SpecificationsFlag { get; set; } = null!;
        public string SupplementItemFlag { get; set; } = null!;
        public string OpeGroupCode { get; set; } = null!;
        public string? StartTimeKey { get; set; }
        public string? MaterialCategCode { get; set; }
    }
}
