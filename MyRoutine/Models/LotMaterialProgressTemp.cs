using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LotMaterialProgressTemp
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string MaterialLotNo { get; set; } = null!;
        public string MaterialLotNoSuffix { get; set; } = null!;
        public string MaterialName { get; set; } = null!;
        public string MaterialCateg { get; set; } = null!;
        public string? MaterialCategName { get; set; }
        public int? InputQty { get; set; }
        public int? SubInputQty { get; set; }
        public int? SurplusInQty { get; set; }
        public int? SubSurplusInQty { get; set; }
        public string InputUnit { get; set; } = null!;
        public string? InputUnitName { get; set; }
        public int? OutputQty { get; set; }
        public int? SubOutputQty { get; set; }
        public int? TotalDefectQty { get; set; }
        public int? SubTotalDefectQty { get; set; }
        public int? SurplusOutQty { get; set; }
        public int? SubSurplusOutQty { get; set; }
        public int? SampleQty { get; set; }
        public int? SubSampleQty { get; set; }
        public int? UnclearQty { get; set; }
        public int? SubUnclearQty { get; set; }
        public string OutputUnit { get; set; } = null!;
        public string? OutputUnitName { get; set; }
        public string ShowMaterialInput { get; set; } = null!;
        public string UpdateLotProgress { get; set; } = null!;
        public bool MatQtyCheck { get; set; }
        public string? MatDefectInput { get; set; }
        public string? MatSurplusIninput { get; set; }
        public string? MatSurplusOutinput { get; set; }
        public string? MatSampleInput { get; set; }
        public string? MatIninput { get; set; }
        public string? MatOutinput { get; set; }
        public string? MatUnclearInput { get; set; }
        public int? DisplayOrder { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
