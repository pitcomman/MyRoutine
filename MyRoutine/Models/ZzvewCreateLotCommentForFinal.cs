using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZzvewCreateLotCommentForFinal
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string? MachineNo { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? CommentNo { get; set; }
    }
}
