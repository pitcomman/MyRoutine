using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZMmaterialLotWafer
    {
        public string Warehouse { get; set; } = null!;
        public string MaterialLotNo { get; set; } = null!;
        public string MaterialLotNoSuffix { get; set; } = null!;
        public string MaterialName { get; set; } = null!;
        public string MakerCode { get; set; } = null!;
        public string Unit { get; set; } = null!;
        public string MaterialCateg { get; set; } = null!;
        public string MaterialCategoryName { get; set; } = null!;
        public int Qty { get; set; }
        public DateTime? ExpireDate { get; set; }
        public int? AvailableStartTime { get; set; }
        public int? AvailableEndTime { get; set; }
        public int StockOutCheck { get; set; }
    }
}
