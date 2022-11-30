using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TblBq
    {
        public string Bqcode { get; set; } = null!;
        public string? Bqname { get; set; }
        public string OpeCode { get; set; } = null!;
        public DateTime? UpdDate { get; set; }
    }
}
