using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ProcessOutput
    {
        public string ProcessCode { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string OutputCode { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
