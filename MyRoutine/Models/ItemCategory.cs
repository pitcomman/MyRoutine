using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ItemCategory
    {
        public string ItemCateg { get; set; } = null!;
        public string? ItemCategName { get; set; }
        public string? Remarks1 { get; set; }
        public string? Remarks2 { get; set; }
        public string? Remarks3 { get; set; }
        public string? Remarks4 { get; set; }
        public string? Remarks5 { get; set; }
        public string? RemarksTitle1 { get; set; }
        public string? RemarksTitle2 { get; set; }
        public string? RemarksTitle3 { get; set; }
        public string? RemarksTitle4 { get; set; }
        public string? RemarksTitle5 { get; set; }
        public string? RemarksColor1 { get; set; }
        public string? RemarksColor2 { get; set; }
        public string? RemarksColor3 { get; set; }
        public string? RemarksColor4 { get; set; }
        public string? RemarksColor5 { get; set; }
        public string InputKind { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
