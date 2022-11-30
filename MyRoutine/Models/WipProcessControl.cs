using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class WipProcessControl
    {
        public string LineGroupId { get; set; } = null!;
        public string LineId { get; set; } = null!;
        public string CheckProcessCode { get; set; } = null!;
        public string FromProcessCode { get; set; } = null!;
        public int FromProcesssing { get; set; }
        public string ToProcessCode { get; set; } = null!;
        public int ToProcesssing { get; set; }
        public decimal MaxWiplotCount { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
