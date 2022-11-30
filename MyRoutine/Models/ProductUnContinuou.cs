using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ProductUnContinuou
    {
        public string ProcessCode { get; set; } = null!;
        public string Type1 { get; set; } = null!;
        public string ProductCode1 { get; set; } = null!;
        public string Type2 { get; set; } = null!;
        public string ProductCode2 { get; set; } = null!;
        public string CommentCateg { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
