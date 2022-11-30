using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Language
    {
        public string GroupCode { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Value1 { get; set; } = null!;
        public string? Value2 { get; set; }
        public string? Value3 { get; set; }
        public string? Description { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
