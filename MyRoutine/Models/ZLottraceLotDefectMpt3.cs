using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZLottraceLotDefectMpt3
    {
        public string LotNo { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public string DefectCode { get; set; } = null!;
        public int DefectQty { get; set; }
        public DateTime UpdDate { get; set; }
        public string Operator { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public string ProcessName { get; set; } = null!;
        public string NcimProcessCode { get; set; } = null!;
        public string? NcimProcessName { get; set; }
        public string ProcessCode3rd { get; set; } = null!;
        public string ProcessCode8th { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string DefectName { get; set; } = null!;
    }
}
