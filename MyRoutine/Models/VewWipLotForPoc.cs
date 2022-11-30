using System;
using System.Collections.Generic;

namespace MyRoutine.Models
{
    public partial class VewWipLotForPoc
    {
        public string? LineId { get; set; }
        public string? FirstMachineNo { get; set; }
        public string LotNo { get; set; } = null!;
        public string LotNoSuffix { get; set; } = null!;
        public string Type { get; set; } = null!;
        public string ProductCode { get; set; } = null!;
        public string ProductCateg { get; set; } = null!;
        public string ProductFamily { get; set; } = null!;
        public int ProcessSeqNo { get; set; }
        public string ProcessCode { get; set; } = null!;
        public string? ProcessName { get; set; }
        public DateTime? StartPlanTime { get; set; }
        public DateTime? EndPlanTime { get; set; }
        public string? MachineNo { get; set; }
        public string? MachineName { get; set; }
        public DateTime? StartTime { get; set; }
        public string? StartOperatorId { get; set; }
        public string? StartOperatorName { get; set; }
        public DateTime? EndTime { get; set; }
        public string? EndOperatorId { get; set; }
        public string? EndOperatorName { get; set; }
        public int? InputQty { get; set; }
        public int? SubInputQty { get; set; }
        public int? OutputQty { get; set; }
        public int? SubOutputQty { get; set; }
        public int? TotalDefectQty { get; set; }
        public int? SubTotalDefectQty { get; set; }
        public DateTime? MachineStartTime { get; set; }
        public DateTime? MachineEndTime { get; set; }
        public string? MachineProductionTime { get; set; }
        public string? MachineStopTime { get; set; }
        public string? MachineAlarmTime { get; set; }
        public DateTime AddDate { get; set; }
        public DateTime UpdDate { get; set; }
        public string UserName { get; set; } = null!;
        public string ComputerName { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string MoniProc { get; set; } = null!;
        public string OrderNo { get; set; } = null!;
        public int? WipQty { get; set; }
    }
}
