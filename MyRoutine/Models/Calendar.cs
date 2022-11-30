using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Calendar
    {
        public DateTime CalendarDate { get; set; }
        public string WeekMark { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
