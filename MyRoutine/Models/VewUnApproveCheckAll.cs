using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewUnApproveCheckAll
    {
        public string? ManageClassName { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string StandardNo { get; set; } = null!;
        public string StandardName { get; set; } = null!;
        public DateTime WorkStartTime { get; set; }
        public string MachineNo { get; set; } = null!;
        public string WorkCategory { get; set; } = null!;
        public string CycleCode { get; set; } = null!;
        public string? ApproveId { get; set; }
        public DateTime? ApproveDate { get; set; }
    }
}
