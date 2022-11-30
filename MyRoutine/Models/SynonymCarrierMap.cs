using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class SynonymCarrierMap
    {
        public string CarrierNo { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string? SerialNo { get; set; }
        public string? LotNo { get; set; }
        public string? LotSfxNo { get; set; }
        public string? ProcessCode { get; set; }
        public string? MachineNo { get; set; }
        public string? SlotNo { get; set; }
        public DateTime MappingTime { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string ComputerName { get; set; } = null!;
        public string UserName { get; set; } = null!;
    }
}
