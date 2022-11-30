using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class WebApiparameter
    {
        public string ParameterCode { get; set; } = null!;
        public string ParameterName { get; set; } = null!;
        public string ParameterValue { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
