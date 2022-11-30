using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZtclimitCtrl
    {
        public string Ztccateg { get; set; } = null!;
        public string Ztcname { get; set; } = null!;
        public int ConditionNo { get; set; }
        public string ConditionName { get; set; } = null!;
        public int? MaxTime { get; set; }
        public string? BaseTimeOpeCode1 { get; set; }
        public string? BaseTimeOpeCateg1 { get; set; }
        public string? BaseTimeOpeCode2 { get; set; }
        public string? BaseTimeOpeCateg2 { get; set; }
        public string? BaseTimeOpeCode3 { get; set; }
        public string? BaseTimeOpeCateg3 { get; set; }
        public int? MaxCount { get; set; }
        public string? CountUpOpeCode1 { get; set; }
        public int? CountUp1 { get; set; }
        public string? CountUpOpeCode2 { get; set; }
        public int? CountUp2 { get; set; }
        public string? CountUpOpeCode3 { get; set; }
        public int? CountUp3 { get; set; }
        public string? CountClearOpeCode1 { get; set; }
        public int? CountClear1 { get; set; }
        public string? CountClearOpeCode2 { get; set; }
        public int? CountClear2 { get; set; }
        public string? CountClearOpeCode3 { get; set; }
        public int? CountClear3 { get; set; }
        public string? CheckOpeCode1 { get; set; }
        public string? CheckCateg1 { get; set; }
        public string? CheckOpeCode2 { get; set; }
        public string? CheckCateg2 { get; set; }
        public string? CheckOpeCode3 { get; set; }
        public string? CheckCateg3 { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
