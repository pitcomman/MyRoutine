using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewOperatorRoleObject
    {
        public string OperatorId { get; set; } = null!;
        public string RoleId { get; set; } = null!;
        public string ApplicationName { get; set; } = null!;
        public string DisabledObject { get; set; } = null!;
    }
}
