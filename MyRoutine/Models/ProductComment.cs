using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ProductComment
    {
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string FlowId { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public int CommentNo { get; set; }
        public string ProcessSe { get; set; } = null!;
        public string Comment { get; set; } = null!;
        public string CommentCateg { get; set; } = null!;
        public string? CommentLevel { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
