using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class NcimTerminalMenu
    {
        public string Ipaddress { get; set; } = null!;
        public string ApplicationName { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public string MenuId { get; set; } = null!;
        public bool? MachineNoInputFlag { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
