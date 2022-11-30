using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewConversionUnit
    {
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string BeforeUnit { get; set; } = null!;
        public string AfterUnit { get; set; } = null!;
        public int ConversionValue { get; set; }
    }
}
