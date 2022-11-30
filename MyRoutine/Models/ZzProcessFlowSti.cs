using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class ZzProcessFlowSti
    {
        public string FlowId { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public bool ProductEnd { get; set; }
        public bool WipcontrolEnd { get; set; }
        public bool TotalDefectEnd { get; set; }
        public bool DailyAnalysisCheck { get; set; }
        public bool OptionalProcess { get; set; }
        public string QtyCheck { get; set; } = null!;
        public string DefectCheck { get; set; } = null!;
        public bool DeletePermission { get; set; }
        public bool HavingSmallProcess { get; set; }
        public string StartCarrierSet { get; set; } = null!;
        public string StartCarrierCheck { get; set; } = null!;
        public string EndCarrierSet { get; set; } = null!;
        public string EndCarrierCheck { get; set; } = null!;
        public string UpdateCarrierEnd { get; set; } = null!;
        public string UpdateMaterialEnd { get; set; } = null!;
        public string UpdateToolEnd { get; set; } = null!;
        public string SplitLot { get; set; } = null!;
        public string SurplusSucceed { get; set; } = null!;
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
