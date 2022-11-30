using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Testinsert
    {
        public string FactoryCode { get; set; } = null!;
        public string FactoryName { get; set; } = null!;
        public string Category { get; set; } = null!;
        public string Category2 { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProdCode { get; set; } = null!;
        public string Level1 { get; set; } = null!;
        public string? Level2 { get; set; }
        public string PackageName { get; set; } = null!;
        public string LineCode { get; set; } = null!;
        public string? Date1 { get; set; }
        public string? Time1 { get; set; }
        public string? Date2 { get; set; }
        public string? Time2 { get; set; }
        public string? OrderNo { get; set; }
        public string LotNo { get; set; } = null!;
        public string RohmPn { get; set; } = null!;
        public int ProcessNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string? MachineNo { get; set; }
        public string OperatingCategory { get; set; } = null!;
        public decimal? ActQty1 { get; set; }
        public int ActQtyLot1 { get; set; }
        public int ActQty2 { get; set; }
        public int ActQtyLot2 { get; set; }
    }
}
