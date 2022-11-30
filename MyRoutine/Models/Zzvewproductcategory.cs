using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Zzvewproductcategory
    {
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int Pgcode { get; set; }
        public string RohmProductCode { get; set; } = null!;
        public string Trno { get; set; } = null!;
        public string Spec { get; set; } = null!;
        public string Pack { get; set; } = null!;
        public string HFerank { get; set; } = null!;
        public string RohmLine { get; set; } = null!;
        public string? CustomerCode { get; set; }
        public bool Hrcateg { get; set; }
        public bool PbFcateg { get; set; }
        public bool PlatingCateg { get; set; }
        public bool MosfetCateg { get; set; }
        public bool AutoLabelCateg { get; set; }
        public bool? AnalysisCateg { get; set; }
        public bool? PachinkoCateg { get; set; }
        public bool? KeihinCateg { get; set; }
        public bool? DippingCateg { get; set; }
        public DateTime UpdDate { get; set; }
        public string OperatorName { get; set; } = null!;
    }
}
