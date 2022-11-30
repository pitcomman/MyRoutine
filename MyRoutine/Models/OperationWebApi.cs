using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class OperationWebApi
    {
        public string OperationCode { get; set; } = null!;
        public string ProcessCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public int ExecutionOrder { get; set; }
        public string Httpmethod { get; set; } = null!;
        public string WebApi { get; set; } = null!;
        public string ParameterCode { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
