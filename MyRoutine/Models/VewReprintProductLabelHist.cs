using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewReprintProductLabelHist
    {
        public DateTime ReprintDate { get; set; }
        public string ReprintOperatorId { get; set; } = null!;
        public string ReprintOperatorName { get; set; } = null!;
        public string Reason { get; set; } = null!;
        public string LotNo { get; set; } = null!;
        public string ReelNo { get; set; } = null!;
        public string RohmproductCode { get; set; } = null!;
        public string Mno { get; set; } = null!;
        public string Marking { get; set; } = null!;
        public string CustomerProductCode { get; set; } = null!;
        public string ReelQty { get; set; } = null!;
        public string Pbfree { get; set; } = null!;
        public string UserPartsNo { get; set; } = null!;
        public string BarCode1 { get; set; } = null!;
        public string BarCode2 { get; set; } = null!;
        public string Qrcode { get; set; } = null!;
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
