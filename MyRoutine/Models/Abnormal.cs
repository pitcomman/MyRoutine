using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Abnormal
    {
        public string AbnormalCode { get; set; } = null!;
        public string? AbnormalName { get; set; }
        public string AndonHistory { get; set; } = null!;
        public string SystemTrigger { get; set; } = null!;
        public string AbnormalRegistration { get; set; } = null!;
        public string Ncn { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
