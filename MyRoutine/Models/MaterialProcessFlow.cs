using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class MaterialProcessFlow
    {
        public string FlowId { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string MaterialCateg { get; set; } = null!;
        public string ShowMaterialInput { get; set; } = null!;
        public string UpdateLotProgress { get; set; } = null!;
        public bool MatQtyCheck { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
