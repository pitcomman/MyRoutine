using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TblBqclassDaoDv
    {
        public string ClassDv { get; set; } = null!;
        public string CurrentDay { get; set; } = null!;
        public string StartTime { get; set; } = null!;
        public string? EndTime { get; set; }
        public decimal? Time { get; set; }
    }
}
