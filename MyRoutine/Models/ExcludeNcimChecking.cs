using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ExcludeNcimChecking
    {
        public string ExcludeCheckItem { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
