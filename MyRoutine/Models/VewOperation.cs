using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewOperation
    {
        public string OpeGroupCode { get; set; } = null!;
        public string? OpeGroupName { get; set; }
        public string OpeGroupCateg { get; set; } = null!;
        public string? MaterialCateg { get; set; }
        public string OperationCode { get; set; } = null!;
        public string? OperationName { get; set; }
        public string StartEndFlag { get; set; } = null!;
        public string LotNoInputFlag { get; set; } = null!;
        public string? InputKind { get; set; }
        public string? ChangeMachineStatus { get; set; }
        public string? ChangeDisableStatus { get; set; }
        public string OpeScope { get; set; } = null!;
        public string Equipment { get; set; } = null!;
        public string? BarcodeQrformat { get; set; }
        public string? InputItemControl { get; set; }
        public string? InputSetQty { get; set; }
        public string? InputUseQty { get; set; }
        public string? InputRemainQty { get; set; }
        public string? InputQtyUnit { get; set; }
        public string? InputQtyUnitName { get; set; }
        public string SpecialOperate { get; set; } = null!;
        public string? SpecialOperationCode { get; set; }
    }
}
