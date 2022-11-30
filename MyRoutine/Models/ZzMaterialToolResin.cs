﻿using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZzMaterialToolResin
    {
        public string Lotno { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public string? OpeGroupName { get; set; }
        public DateTime? StartTime { get; set; }
        public int? InputQty { get; set; }
        public int? OutputQty { get; set; }
        public DateTime? EndTime { get; set; }
        public string? MachineName { get; set; }
        public string MaterialLotNo { get; set; } = null!;
        public string MaterialLotNoSuffix { get; set; } = null!;
        public string? MaterialName { get; set; }
        public string? MaterialCateg { get; set; }
        public string? MaterialCategName { get; set; }
        public string? MaterialSpec { get; set; }
    }
}
