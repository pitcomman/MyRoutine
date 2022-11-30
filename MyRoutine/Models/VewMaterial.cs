using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewMaterial
    {
        public string MaterialName { get; set; } = null!;
        public string? MaterialSpec { get; set; }
        public string? MakerCode { get; set; }
        public string MaterialCateg { get; set; } = null!;
        public string MaterialCategory { get; set; } = null!;
        public string MaterialCategoryGroup { get; set; } = null!;
        public string Unit { get; set; } = null!;
        public string? UnitName { get; set; }
        public string LogisticsUnit { get; set; } = null!;
        public string? LogisticsUnitName { get; set; }
        public decimal MinInQty { get; set; }
        public decimal MaterialYieldRate { get; set; }
        public int AvailableTimeSetFlag { get; set; }
        public int? AvailableStartMin { get; set; }
        public int? AvailableEndMin { get; set; }
    }
}
