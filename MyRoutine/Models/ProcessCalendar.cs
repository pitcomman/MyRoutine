using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ProcessCalendar
    {
        public string InventoryMonth { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
