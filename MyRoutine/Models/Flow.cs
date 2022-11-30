using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Flow
    {
        public string FlowId { get; set; } = null!;
        public string? FlowName { get; set; }
        public bool UpdLotComplete { get; set; }
        public string? Remarks { get; set; }
        public string FlowType { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
