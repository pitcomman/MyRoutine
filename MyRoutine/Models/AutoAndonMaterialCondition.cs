using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class AutoAndonMaterialCondition
    {
        public int ConditionId { get; set; }
        public string ConditionName { get; set; } = null!;
        public string ControlType { get; set; } = null!;
        public string MaterialCateg { get; set; } = null!;
        public string MaterialCategName { get; set; } = null!;
        public string MaterialName { get; set; } = null!;
        public string MaterialSpec { get; set; } = null!;
        public string? FromWarehouse { get; set; }
        public string? FromWarehouseName { get; set; }
        public string? FromLocation { get; set; }
        public string? ToWarehouse { get; set; }
        public string? ToWarehouseName { get; set; }
        public string? ToLocation { get; set; }
        public string? MoveWarehouse { get; set; }
        public string? MoveWarehouseName { get; set; }
        public string? MoveLocation { get; set; }
        public string? SpecialCondition { get; set; }
        public decimal? BaseResult { get; set; }
        public string Unit { get; set; } = null!;
        public string MaterialCondition { get; set; } = null!;
        public string? Sign { get; set; }
        public decimal? Threshold { get; set; }
        public string? MailSend { get; set; }
        public string? AddressGroup { get; set; }
        public string? MailFormat { get; set; }
        public string? MailFormatCode { get; set; }
        public string MaterialStop { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
