﻿using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ProductGroup
    {
        public string ProductGroup1 { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
