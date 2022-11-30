using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class DisplayDetail
    {
        public string OperatorId { get; set; } = null!;
        public string SettingName { get; set; } = null!;
        public int FormNo { get; set; }
        public string FormName { get; set; } = null!;
        public int FormSizeW { get; set; }
        public int FormSizeH { get; set; }
        public int FormPositionX { get; set; }
        public int FormPositionY { get; set; }
        public int? PositionNo { get; set; }
        public string? SearchInfo { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
