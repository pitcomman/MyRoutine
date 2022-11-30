using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class InputItem
    {
        public string ItemCode { get; set; } = null!;
        public string? ItemName { get; set; }
        public string InputType { get; set; } = null!;
        public string DataType { get; set; } = null!;
        public int? DecimalNo { get; set; }
        public string? Unit { get; set; }
        public string? ValueCode { get; set; }
        public string InputOption { get; set; } = null!;
        public string? DefaultValue { get; set; }
        public string? Calculation { get; set; }
        public bool ReadOnly { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
