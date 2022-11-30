using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class MaintenanceSystemLog
    {
        public int LogId { get; set; }
        public string? Pcname { get; set; }
        public string? UserName { get; set; }
        public DateTime LoggingDate { get; set; }
        public string? LoginUserId { get; set; }
        public string? LoginUserName { get; set; }
        public string Thread { get; set; } = null!;
        public string Level { get; set; } = null!;
        public string Logger { get; set; } = null!;
        public string Message { get; set; } = null!;
    }
}
