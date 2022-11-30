using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class LotProgress20220906
    {
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductFamily { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public string? OrderNo { get; set; }
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public DateTime? StartPlanTime { get; set; }
        public DateTime? EndPlanTime { get; set; }
        public string? MachineNo { get; set; }
        public string? MachineName { get; set; }
        public string? LineId { get; set; }
        public string? LineName { get; set; }
        public DateTime? StartTime { get; set; }
        public string? StartOperatorId { get; set; }
        public string? StartOperatorName { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public int? InputQty { get; set; }
        public int? SubInputQty { get; set; }
        public decimal? InputLotCount { get; set; }
        public int? SurplusInQty { get; set; }
        public int? SubSurplusInQty { get; set; }
        public int? TotalBlendInQty { get; set; }
        public int? SubTotalBlendInQty { get; set; }
        public string InputUnit { get; set; } = null!;
        public string? InputUnitName { get; set; }
        public int? OutputQty { get; set; }
        public int? SubOutputQty { get; set; }
        public decimal? OutputLotCount { get; set; }
        public int? TotalDefectQty { get; set; }
        public int? SubTotalDefectQty { get; set; }
        public int? SurplusOutQty { get; set; }
        public int? SubSurplusOutQty { get; set; }
        public int? TotalBlendOutQty { get; set; }
        public int? SubTotalBlendOutQty { get; set; }
        public int? SampleQty { get; set; }
        public int? SubSampleQty { get; set; }
        public int? UnclearQty { get; set; }
        public int? SubUnclearQty { get; set; }
        public string OutputUnit { get; set; } = null!;
        public string? OutputUnitName { get; set; }
        public DateTime? MachineStartTime { get; set; }
        public DateTime? MachineEndTime { get; set; }
        public string? MachineProductionTime { get; set; }
        public string? MachineStopTime { get; set; }
        public string? MachineAlarmTime { get; set; }
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
        public string ContinuousStartFlg { get; set; } = null!;
        public string RegistType { get; set; } = null!;
        public string? Ncnno { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
    }
}
