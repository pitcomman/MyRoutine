using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class MmaterialLotBak20170131
    {
        public string Warehouse { get; set; } = null!;
        public string MaterialLotNo { get; set; } = null!;
        public string MaterialLotNoSuffix { get; set; } = null!;
        public string? MaterialName { get; set; }
        public string? MakerCode { get; set; }
        public string Unit { get; set; } = null!;
        public string MaterialCateg { get; set; } = null!;
        public string MaterialCategoryName { get; set; } = null!;
        public decimal Qty { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int? AvailableStartTime { get; set; }
        public int? AvailableEndTime { get; set; }
        public int StockOutCheck { get; set; }
    }
}
