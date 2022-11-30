using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class TblBqunLockTran
    {
        public int UnLockId { get; set; }
        public string? MachineNo { get; set; }
        public string? MachineName { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public int? TotalMin { get; set; }
        public string? LockOperator { get; set; }
        public string? AlarmTime { get; set; }
        public string? UnLockRemarks { get; set; }
        public string? UnLockOperator { get; set; }
        public DateTime? UpdDate { get; set; }
    }
}
