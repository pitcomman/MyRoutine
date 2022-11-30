using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class NcimMenuItem
    {
        public string MenuId { get; set; } = null!;
        public string MenuCode { get; set; } = null!;
        public string MenuTitle { get; set; } = null!;
        public string Url { get; set; } = null!;
        public string MenuColor { get; set; } = null!;
        public string? ParentMenuCode { get; set; }
        public string? OperationCode { get; set; }
        public int OrderSeq { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
