using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class SmallProcessFlow
    {
        public string FlowId { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public int SmallProcessSeqNo { get; set; }
        public string SmallProcessCode { get; set; } = null!;
        public bool OptionalProcess { get; set; }
        public bool QtyCheck { get; set; }
        public bool DeletePermission { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
