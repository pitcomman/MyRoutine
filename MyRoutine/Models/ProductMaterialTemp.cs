using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ProductMaterialTemp
    {
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public string MachineCateg { get; set; } = null!;
        public string SlotNo { get; set; } = null!;
        public string MaterialSpec { get; set; } = null!;
        public int Priority { get; set; }
        public string? OpeGroupCode { get; set; }
        public string? ConbinationName { get; set; }
        public string UnneedMaterialCheck { get; set; } = null!;
    }
}
