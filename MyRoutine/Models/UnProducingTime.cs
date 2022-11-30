using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class UnProducingTime
    {
        public string LineId { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
