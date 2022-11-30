using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class MaterialSpecification
    {
        public string MaterialSpec { get; set; } = null!;
        public string MakerCode { get; set; } = null!;
        public int SpecificationsNo { get; set; }
        public string SpecificationsPath { get; set; } = null!;
        public string? Remarks { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
