using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TblBqclass
    {
        public string OperatorCode { get; set; } = null!;
        public string? OperatorName { get; set; }
        public string? Class { get; set; }
        public string? Tips { get; set; }
        public string? ClassDv { get; set; }
        public DateTime? UpdDate { get; set; }
    }
}
