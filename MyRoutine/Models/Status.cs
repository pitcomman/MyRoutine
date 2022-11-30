using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Status
    {
        public string StatusCode { get; set; } = null!;
        public string? StatusName { get; set; }
        public string Mlc21statusCode { get; set; } = null!;
        public string StopFlag { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
