using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class InputItemList
    {
        public string ItemCateg { get; set; } = null!;
        public string ItemCode { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
