using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewTypeGroupProduct
    {
        public string TypeGroup { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string? ProductCode { get; set; }
        public int SortDisp { get; set; }
    }
}
