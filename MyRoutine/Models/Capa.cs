using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Capa
    {
        public string? Type { get; set; }
        public string? MachineNo { get; set; }
        public double? 設備数 { get; set; }
        public double? Rpm { get; set; }
        public double? 稼働率 { get; set; }
        public double? Mstart { get; set; }
        public double? Mend { get; set; }
    }
}
