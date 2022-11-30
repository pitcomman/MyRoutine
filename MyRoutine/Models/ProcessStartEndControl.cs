using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ProcessStartEndControl
    {
        public string FlowId { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string StartEndFlag { get; set; } = null!;
        public int ControlTime { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
