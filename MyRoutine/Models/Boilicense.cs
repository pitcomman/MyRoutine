using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Boilicense
    {
        public string LicenseNo { get; set; } = null!;
        public string? LicenseName { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
