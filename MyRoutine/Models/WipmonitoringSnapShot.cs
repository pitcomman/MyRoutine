﻿using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class WipmonitoringSnapShot
    {
        public DateTime FromDate { get; set; }
        public string LineId { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public int WiplotCount { get; set; }
        public int? Wipqty { get; set; }
        public string? Wipunit { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
