using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LotActualUnit
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public DateTime EndTime { get; set; }
        public int OutputQty { get; set; }
        public string MaterialCateg { get; set; } = null!;
        public string MaterialCategName { get; set; } = null!;
        public string MaterialName { get; set; } = null!;
        public string MaterialSpec { get; set; } = null!;
        public decimal UsedQty { get; set; }
        public decimal StandardUnitQty { get; set; }
        public decimal ActualUnitQty { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
