using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TblBqtable
    {
        public int SeqNo { get; set; }
        public string? OpName { get; set; }
        public string? Bqcode { get; set; }
        public string? Bqname { get; set; }
        public string? MachineNo { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public decimal? Time { get; set; }
    }
}
