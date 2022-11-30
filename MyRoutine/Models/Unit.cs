using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Unit
    {
        public string Unit1 { get; set; } = null!;
        public string? UnitName { get; set; }
        public string Mlc21unit { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
