using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LineM
    {
        public string LineId { get; set; } = null!;
        public string? LineName { get; set; }
        public decimal? MaxWiplotCount { get; set; }
        public string LineGroupId { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
