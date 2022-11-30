using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class MmaterialLot
    {
        public string Warehouse { get; set; } = null!;
        public string MaterialLotNo { get; set; } = null!;
        public string? MaterialLotNoSuffix { get; set; }
        public string MaterialName { get; set; } = null!;
        public string? MaterialSpec { get; set; }
        public string? MakerCode { get; set; }
        public string UnitCode { get; set; } = null!;
        public string Unit { get; set; } = null!;
        public string MaterialCateg { get; set; } = null!;
        public string MaterialCategoryName { get; set; } = null!;
        public decimal? Qty { get; set; }
        public DateTime? ExpireDate { get; set; }
        public DateTime? AvailableStartTime { get; set; }
        public DateTime? AvailableEndTime { get; set; }
        public int StockOutCheck { get; set; }
        public string WarehouseCateg { get; set; } = null!;
        public bool StopFlag { get; set; }
    }
}
