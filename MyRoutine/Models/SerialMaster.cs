using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class SerialMaster
    {
        public string SerialNo { get; set; } = null!;
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductFamily { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public int InputQty { get; set; }
        public int SubInputQty { get; set; }
        public int DefectQty { get; set; }
        public int SubDefectQty { get; set; }
        public string InputUnit { get; set; } = null!;
        public string InputUnitName { get; set; } = null!;
        public string SubUnit { get; set; } = null!;
        public string SubUnitName { get; set; } = null!;
        public string Status { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
