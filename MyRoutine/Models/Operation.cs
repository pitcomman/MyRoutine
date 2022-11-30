using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class Operation
    {
        public string OperationCode { get; set; } = null!;
        public string? OperationName { get; set; }
        public string StartEndFlag { get; set; } = null!;
        public string OpeGroupCode { get; set; } = null!;
        public string LotNoInputFlag { get; set; } = null!;
        public string? InputKind { get; set; }
        public string? ChangeMachineStatus { get; set; }
        public string? ChangeDisableStatus { get; set; }
        public string? BarcodeQrformat { get; set; }
        public string OpeScope { get; set; } = null!;
        public string? InputSetQty { get; set; }
        public string? InputUseQty { get; set; }
        public string? InputRemainQty { get; set; }
        public string? InputQtyUnit { get; set; }
        public string? InputItemControl { get; set; }
        public string Equipment { get; set; } = null!;
        public string? ProductChange { get; set; }
        public bool IsArrangement { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
