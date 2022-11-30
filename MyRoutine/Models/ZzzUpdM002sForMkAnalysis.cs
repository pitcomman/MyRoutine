using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZzzUpdM002sForMkAnalysis
    {
        public string OperationCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public string Ztcname { get; set; } = null!;
        public string ItemCateg { get; set; } = null!;
        public string InputOption { get; set; } = null!;
        public int DisplayOrder { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
