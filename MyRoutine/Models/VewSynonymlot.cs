using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewSynonymlot
    {
        public string LotNo { get; set; } = null!;
        public string? LotNoSuffix { get; set; }
        public string Type { get; set; } = null!;
        public string Sline { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string RohmProductCode { get; set; } = null!;
        public string ReceivingCateg { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public string OrderNo { get; set; } = null!;
        public DateTime InputDate { get; set; }
        public DateTime OutputDate { get; set; }
        public int InputQty { get; set; }
        public int OutputQty { get; set; }
        public int PackUnitQty { get; set; }
        public string InputProcCode { get; set; } = null!;
        public string OutputProcCode { get; set; } = null!;
        public string RouteNo { get; set; } = null!;
        public byte Priority { get; set; }
        public bool ReInputLot { get; set; }
        public bool UseOldLotNo { get; set; }
        public int CompleteQty { get; set; }
        public int CancelQty { get; set; }
        public DateTime? CompleteDate { get; set; }
        public bool WorkslipPrinted { get; set; }
        public bool ProductLabelPrinted { get; set; }
        public string Status { get; set; } = null!;
    }
}
