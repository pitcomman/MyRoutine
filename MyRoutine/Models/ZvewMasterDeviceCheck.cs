using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZvewMasterDeviceCheck
    {
        public string OperationCode { get; set; } = null!;
        public string? OperationName { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public string OperationItemCategItemCateg { get; set; } = null!;
        public int OperationItemCategDisplayOrder { get; set; }
        public string OperationItemCategInputOption { get; set; } = null!;
        public string ItemCategoryItemCateg { get; set; } = null!;
        public string? ItemCategoryItemCategName { get; set; }
        public string? ItemCategoryRemarks1 { get; set; }
        public string InputItemListItemCode { get; set; } = null!;
        public string? InputItemItemName { get; set; }
        public string InputItemInputType { get; set; } = null!;
        public string InputItemDataType { get; set; } = null!;
        public string? InputItemUnit { get; set; }
        public int InputItemListDisplayOrder { get; set; }
        public string? InputItemValueCode { get; set; }
        public bool InputItemReadOnly { get; set; }
        public string InputItemInputOption { get; set; } = null!;
    }
}
