using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ProductlUnContinuou
    {
        public string ProcessCode { get; set; } = null!;
        public int GroupNo { get; set; }
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string CommentCateg { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
