using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class MaterialMachine
    {
        public string MachineNo { get; set; } = null!;
        public string MaterialCateg { get; set; } = null!;
        public string MatDefectInput { get; set; } = null!;
        public string MatSurplusIninput { get; set; } = null!;
        public string MatSurplusOutinput { get; set; } = null!;
        public string MatSampleInput { get; set; } = null!;
        public string MatIninput { get; set; } = null!;
        public string MatOutinput { get; set; } = null!;
        public string MatUnclearInput { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
