using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZLottraceLotResultMpt3mc
    {
        public string LotNo { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int ProductQty { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime UpdDate { get; set; }
        public string Operator { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public string ProcessName { get; set; } = null!;
        public string NcimProcessCode { get; set; } = null!;
        public string? NcimProcessName { get; set; }
        public string ProcessCode3rd { get; set; } = null!;
        public string ProcessCode8th { get; set; } = null!;
    }
}
