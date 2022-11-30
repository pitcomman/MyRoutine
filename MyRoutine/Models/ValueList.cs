using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ValueList
    {
        public string ValueCode { get; set; } = null!;
        public string Value { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
