using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewXrayFifo
    {
        public string Type { get; set; } = null!;
        public string LotNo { get; set; } = null!;
        public DateTime? EndTime { get; set; }
    }
}
