using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ProcessDefect
    {
        public string ProcessCode { get; set; } = null!;
        public string DefectCode { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public bool Unscrap { get; set; }
        public string DefectCateg { get; set; } = null!;
        public bool NegativeInput { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
