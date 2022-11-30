using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TblBqitem
    {
        public string Bqcode { get; set; } = null!;
        public string? Bqname { get; set; }
        public string BqnewName { get; set; } = null!;
        public DateTime? UpdDate { get; set; }
    }
}
