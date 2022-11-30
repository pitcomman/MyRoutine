using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewProductRoute
    {
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string RohmProductCode { get; set; } = null!;
        public string Trno { get; set; } = null!;
        public string Spec { get; set; } = null!;
        public string Pack { get; set; } = null!;
        public string HFerank { get; set; } = null!;
        public string RohmLine { get; set; } = null!;
        public string? CustomerCode { get; set; }
        public string RouteNo { get; set; } = null!;
        public DateTime UpdDate { get; set; }
        public string OperatorName { get; set; } = null!;
        public int Pgcode { get; set; }
    }
}
