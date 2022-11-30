using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewTypeNcim
    {
        public string Type { get; set; } = null!;
        public string ProdFamily { get; set; } = null!;
        public string Line { get; set; } = null!;
        public bool? ActualRun { get; set; }
        public DateTime UpdDate { get; set; }
        public string Operator { get; set; } = null!;
        public string OperatorName { get; set; } = null!;
    }
}
