using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Role
    {
        public string RoleId { get; set; } = null!;
        public string ApplicationName { get; set; } = null!;
        public string? Remarks { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
