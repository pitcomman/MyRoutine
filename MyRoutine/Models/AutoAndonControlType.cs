using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class AutoAndonControlType
    {
        public string ControlType { get; set; } = null!;
        public string ControlTypeName { get; set; } = null!;
        public string AndonTarget { get; set; } = null!;
        public string ControlTypeColor { get; set; } = null!;
        public int DisplaySeq { get; set; }
        public string AbnormalCode { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
