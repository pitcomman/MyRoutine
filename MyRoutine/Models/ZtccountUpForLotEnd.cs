using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZtccountUpForLotEnd
    {
        public string Ztccateg { get; set; } = null!;
        public string Ztcname { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string? InOrOut { get; set; }
        public int CountUp { get; set; }
        public int DummyCountUp { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
