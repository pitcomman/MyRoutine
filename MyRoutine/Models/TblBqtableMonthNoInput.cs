using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TblBqtableMonthNoInput
    {
        public int SeqNo { get; set; }
        public string? Name { get; set; }
        public string? Bqcode { get; set; }
        public string? Bqname { get; set; }
        public string? MachineNo { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? Time { get; set; }
        public string? ClassDv { get; set; }
    }
}
