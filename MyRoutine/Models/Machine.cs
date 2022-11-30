using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Machine
    {
        public string MachineNo { get; set; } = null!;
        public string? MachineName { get; set; }
        public string StatusCode { get; set; } = null!;
        public string? ParentMachineNo { get; set; }
        public int MachineType { get; set; }
        public string DefectInput { get; set; } = null!;
        public string SurplusIninput { get; set; } = null!;
        public string SurplusOutinput { get; set; } = null!;
        public string? SurplusOutcalculation { get; set; }
        public string BlendInput { get; set; } = null!;
        public string? BlendDefaultValue { get; set; }
        public string SampleInput { get; set; } = null!;
        public string Ininput { get; set; } = null!;
        public string Outinput { get; set; } = null!;
        public string? Outcalculation { get; set; }
        public string UnclearInput { get; set; } = null!;
        public string? UnclearCalculation { get; set; }
        public string SpecialInput { get; set; } = null!;
        public string? SpecialInputName { get; set; }
        public string? AlarmType { get; set; }
        public string? Eqpifcode { get; set; }
        public string? LicenseNo { get; set; }
        public string ProductChange { get; set; } = null!;
        public string? ChangeProductCode { get; set; }
        public string? ChangeProductCateg { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
