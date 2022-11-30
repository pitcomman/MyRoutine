using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZzSupplementItemCategMaking
    {
        public string OperationCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public string Ztcname { get; set; } = null!;
        public string ItemCateg { get; set; } = null!;
        public string InputOption { get; set; } = null!;
        public int DisplayOrder { get; set; }
    }
}
