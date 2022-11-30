using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class NcimTerminalControl
    {
        public string Ipaddress { get; set; } = null!;
        public string? TerminalName { get; set; }
        public string? TerminalType { get; set; }
        public string? PlaceOfUse { get; set; }
        public string? Memo { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
