using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ShiftCalendar
    {
        public DateTime ShiftDay { get; set; }
        public string TimeZoneCode { get; set; } = null!;
        public string ShiftType { get; set; } = null!;
        public string ShiftName { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string? UserName { get; set; }
        public string ComputerName { get; set; } = null!;
    }
}
