using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewLineFirstMachineNo
    {
        public string FlowId { get; set; } = null!;
        public string LineId { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public string FirstMachineNo { get; set; } = null!;
        public int? ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
    }
}
