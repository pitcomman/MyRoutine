using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewDefectLotInq
    {
        public string ControlNo { get; set; } = null!;
        public string LotNo { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string MachineNo { get; set; } = null!;
        public DateTime ProcessStartTime { get; set; }
        public DateTime AnalysisStartTime { get; set; }
        public DateTime? AnalysisEndTime { get; set; }
        public string? Result { get; set; }
        public string? OperatorName { get; set; }
        public string AnalysisOperatorId { get; set; } = null!;
        public string AnalysisMachineNo { get; set; } = null!;
        public DateTime AddDate { get; set; }
    }
}
