using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class MaterialMountBefore20200801
    {
        public string MachineNo { get; set; } = null!;
        public string? MachineName { get; set; }
        public string OpeGroupCode { get; set; } = null!;
        public string? OpeGroupName { get; set; }
        public string MaterialLotNo { get; set; } = null!;
        public string MaterialLotNoSuffix { get; set; } = null!;
        public string? MaterialName { get; set; }
        public string? MaterialSpec { get; set; }
        public string? MaterialCateg { get; set; }
        public string? MaterialCategName { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public DateTime StartTime { get; set; }
        public string StartOperatorId { get; set; } = null!;
        public string? StartOperatorName { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public decimal? SetQty { get; set; }
        public decimal? UseQty { get; set; }
        public decimal? RemainQty { get; set; }
        public string? QtyUnit { get; set; }
        public string? QtyUnitName { get; set; }
        public string? SlotNo { get; set; }
        public string ProductChange { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
