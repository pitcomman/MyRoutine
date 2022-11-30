using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewDefect
    {
        public string ProcessCode { get; set; } = null!;
        public string DefectCode { get; set; } = null!;
        public string DefectName { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
