using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZvewMasterSupplementCheck
    {
        public string OperationCode { get; set; } = null!;
        public string? OperationName { get; set; }
        public string ItemCategoryItemCateg { get; set; } = null!;
        public string? ItemCategoryItemCategName { get; set; }
        public string InputItemItemCode { get; set; } = null!;
        public string? InputItemItemName { get; set; }
        public string InputItemInputType { get; set; } = null!;
        public string InputItemDataType { get; set; } = null!;
        public string? InputItemUnit { get; set; }
        public int InputItemListDisplayOrder { get; set; }
        public string? InputItemValueCode { get; set; }
        public bool InputItemReadOnly { get; set; }
        public string InputItemInputOption { get; set; } = null!;
        public string? Value { get; set; }
        public string SupplementItemCategMachineNo { get; set; } = null!;
        public string SupplementItemCategItemCateg { get; set; } = null!;
        public string SupplementItemCategInputOption { get; set; } = null!;
        public int SupplementItemCategDisplayOrder { get; set; }
    }
}
