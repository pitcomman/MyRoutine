using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ToolId
    {
        public string ToolLotNo { get; set; } = null!;
        public string ToolName { get; set; } = null!;
        public bool DisableFlag { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
