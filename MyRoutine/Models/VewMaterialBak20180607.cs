using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewMaterialBak20180607
    {
        public string? MaterialName { get; set; }
        public string? MakerCode { get; set; }
        public int? ExpirePriod { get; set; }
        public string? BaseOfExpirePriod { get; set; }
        public string Warehouse { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string? Unit { get; set; }
        public string MaterialCategory { get; set; } = null!;
        public string? StockInUnit { get; set; }
        public string? StockUnit { get; set; }
        public string ConversionCoefficient { get; set; } = null!;
        public decimal MinInQty { get; set; }
        public int? AvailableStartMin { get; set; }
        public int? AvailableEndMin { get; set; }
        public string? Operator { get; set; }
        public int? UpdDate { get; set; }
    }
}
