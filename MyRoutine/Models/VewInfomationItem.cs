using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewInfomationItem
    {
        public string OperationCode { get; set; } = null!;
        public string? OperationName { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public string InputOption { get; set; } = null!;
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
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public string? InputType { get; set; }
        public string? DataType { get; set; }
        public string? Unit { get; set; }
        public int? ItemDisplayOrder { get; set; }
        public string? ValueCode { get; set; }
        public string? ItemInputOption { get; set; }
        public string? DefaultValue { get; set; }
        public string? Calculation { get; set; }
        public int? DecimalNo { get; set; }
        public string InputKind { get; set; } = null!;
    }
}
