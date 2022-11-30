using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class EqpmaintenanceControl
    {
        public string Eqpname { get; set; } = null!;
        public string EqpobjectName { get; set; } = null!;
        public string NcimObjectName { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
