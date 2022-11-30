using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class StandardUnit
    {
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductCategory { get; set; } = null!;
        public short ProductVer { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string MaterialSpec { get; set; } = null!;
        public short MaterialVer { get; set; }
        public string MainSubCategory { get; set; } = null!;
        public string? Orcombination { get; set; }
        public byte? Priority { get; set; }
        public decimal MaterialInputQty { get; set; }
        public string LogisticsUnitCode { get; set; } = null!;
        public int ProductQty { get; set; }
        public decimal StandardUnitQty { get; set; }
        public string ProcessingUnitCode { get; set; } = null!;
        public short KittingTiming { get; set; }
        public bool? KittingOn { get; set; }
        public DateTime EffectiveStartDate { get; set; }
        public DateTime EffectiveEndDate { get; set; }
        public string? FromWarehouse { get; set; }
        public string? ToWarehouse { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string ComputerName { get; set; } = null!;
        public string UserName { get; set; } = null!;
    }
}
