using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LotSplitHistory
    {
        public int SeqNo { get; set; }
        public bool IsParent { get; set; }
        public string LotNo { get; set; } = null!;
        public string LotNoSub { get; set; } = null!;
        public string ParentLotNo { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductModel { get; set; } = null!;
        public string RohmProdCode { get; set; } = null!;
        public string CustProdCode { get; set; } = null!;
        public string Spec { get; set; } = null!;
        public string Tole { get; set; } = null!;
        public string Tcr { get; set; } = null!;
        public string Iecrv { get; set; } = null!;
        public string ProductGroup { get; set; } = null!;
        public string ReceivingCateg { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public string OrderNo { get; set; } = null!;
        public string Pono { get; set; } = null!;
        public string Posno { get; set; } = null!;
        public DateTime InputDate { get; set; }
        public DateTime OutputDate { get; set; }
        public string InputUnit { get; set; } = null!;
        public string OutputUnit { get; set; } = null!;
        public int InputQty { get; set; }
        public int OutputQty { get; set; }
        public int PackUnitQty { get; set; }
        public string InputProcCode { get; set; } = null!;
        public string OutputProcCode { get; set; } = null!;
        public string FlowId { get; set; } = null!;
        public string Priority { get; set; } = null!;
        public bool ReInputLot { get; set; }
        public int LotCompQty { get; set; }
        public int LotCancelQty { get; set; }
        public DateTime? LotCompDate { get; set; }
        public bool WorkSlipPrinted { get; set; }
        public bool ProductLabelPrinted { get; set; }
        public string LotStatusCode { get; set; } = null!;
        public string AbnormalMode { get; set; } = null!;
        public string LotSplitProcess { get; set; } = null!;
        public int? ActualQty { get; set; }
        public string? ActualUnit { get; set; }
        public DateTime UpdDate { get; set; }
        public string Operator { get; set; } = null!;
    }
}
