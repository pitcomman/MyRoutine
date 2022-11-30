using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class AutoAndonMaterialTran
    {
        public int TranId { get; set; }
        public string ControlType { get; set; } = null!;
        public string ControlName { get; set; } = null!;
        public DateTime AndonTime { get; set; }
        public string? ControlLotNo { get; set; }
        public string? ControlLotNoSuffix { get; set; }
        public string? MaterialCateg { get; set; }
        public string? MaterialCategName { get; set; }
        public string? MaterialName { get; set; }
        public string? MaterialSpec { get; set; }
        public string? FromWarehouse { get; set; }
        public string? FromWarehouseName { get; set; }
        public string? FromLocation { get; set; }
        public string? ToWarehouse { get; set; }
        public string? ToWarehouseName { get; set; }
        public string? ToLocation { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public decimal BaseResult { get; set; }
        public decimal ActualResult { get; set; }
        public decimal DifferenceResult { get; set; }
        public decimal DifferenceRate { get; set; }
        public string Unit { get; set; } = null!;
        public string MaterialCondition { get; set; } = null!;
        public string Sign { get; set; } = null!;
        public decimal Threshold { get; set; }
        public string? LotNo { get; set; }
        public string? LotNoSuffix { get; set; }
        public string? Type { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductCateg { get; set; }
        public int? ProcessSeqNo { get; set; }
        public string? ProcessCode { get; set; }
        public string? ProcessName { get; set; }
        public string? MachineNo { get; set; }
        public string? MachineName { get; set; }
        public DateTime? CheckStartTime { get; set; }
        public string? CheckStartOperatorId { get; set; }
        public string? CheckStartOperatorName { get; set; }
        public DateTime? CheckEndTime { get; set; }
        public string? CheckEndOperatorId { get; set; }
        public string? CheckEndOperatorName { get; set; }
        public string? AndonCommt { get; set; }
        public string? DocumentPath { get; set; }
        public string MailSend { get; set; } = null!;
        public string? AddressGroup { get; set; }
        public string MailFormat { get; set; } = null!;
        public string MailFormatCode { get; set; } = null!;
        public int ConditionId { get; set; }
        public DateTime? InventoryDate { get; set; }
        public string MaterialStop { get; set; } = null!;
        public string? CommentRank { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
