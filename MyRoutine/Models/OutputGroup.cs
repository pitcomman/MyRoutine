using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class OutputGroup
    {
        public string OutputGroupCode { get; set; } = null!;
        public string? OutputGroupName { get; set; }
        public string Ipaddress { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
