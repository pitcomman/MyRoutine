using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZtclimitTran
    {
        public string Ztccateg { get; set; } = null!;
        public string Ztcno { get; set; } = null!;
        public string ZtcnoSuffix { get; set; } = null!;
        public string Ztcname { get; set; } = null!;
        public int ConditionNo { get; set; }
        public string ConditionName { get; set; } = null!;
        public DateTime? BaseTime { get; set; }
        public int CurrentCount { get; set; }
        public int OperationCount1 { get; set; }
        public int OperationCount2 { get; set; }
        public int OperationCount3 { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
