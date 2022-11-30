using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewLotResultProdQtyMatLedger
    {
        public string LotNo { get; set; } = null!;
        public string? MachineNo { get; set; }
        public string Type { get; set; } = null!;
        public int? ProductQty { get; set; }
        public DateTime? EndTime { get; set; }
        public string? Process { get; set; }
        public string DepartName { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string DeptType { get; set; } = null!;
        public string DeptMctype { get; set; } = null!;
        public string ProcessCd { get; set; } = null!;
        public string DeptMc { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int? InputQty { get; set; }
        public string Orgline { get; set; } = null!;
        public string DeptTypeProcessName { get; set; } = null!;
        public string DeptTypeProcessCd2 { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
    }
}
