using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class SysVerControl
    {
        public string SysName { get; set; } = null!;
        public string DeviceGroup { get; set; } = null!;
        public string DeviceName { get; set; } = null!;
        public string ReleaseVersion { get; set; } = null!;
        public string CurrentVersion { get; set; } = null!;
        public DateTime? VerUpDate { get; set; }
        public string? Remarks { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
