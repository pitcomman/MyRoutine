using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class NcimOutputControl
    {
        public string AndonType { get; set; } = null!;
        public string ControlType { get; set; } = null!;
        public string OccuredTerminal { get; set; } = null!;
        public bool Emergency { get; set; }
        public string OutputGroupCode { get; set; } = null!;
        public string? AddressGroup { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
