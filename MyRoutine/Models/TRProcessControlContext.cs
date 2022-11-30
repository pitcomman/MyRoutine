using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyRoutine.Models
{
    public partial class TRProcessControlContext : DbContext
    {
        public TRProcessControlContext()
        {
        }

        public TRProcessControlContext(DbContextOptions<TRProcessControlContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Abnormal> Abnormals { get; set; } = null!;
        public virtual DbSet<AbnormalLot> AbnormalLots { get; set; } = null!;
        public virtual DbSet<AbnormalLotTran> AbnormalLotTrans { get; set; } = null!;
        public virtual DbSet<AbnormalSerial> AbnormalSerials { get; set; } = null!;
        public virtual DbSet<AbnormalSerialTran> AbnormalSerialTrans { get; set; } = null!;
        public virtual DbSet<AbnormalTemp> AbnormalTemps { get; set; } = null!;
        public virtual DbSet<ActualWorkingSnapShot> ActualWorkingSnapShots { get; set; } = null!;
        public virtual DbSet<ActualWorkingSnapShot202002> ActualWorkingSnapShot202002s { get; set; } = null!;
        public virtual DbSet<ActualWorkingSummaryCondition> ActualWorkingSummaryConditions { get; set; } = null!;
        public virtual DbSet<ActualWorkingSummaryGroup> ActualWorkingSummaryGroups { get; set; } = null!;
        public virtual DbSet<ActualWorkingTransitionSnapShot> ActualWorkingTransitionSnapShots { get; set; } = null!;
        public virtual DbSet<ActualWorkingTransitionSnapShot202002> ActualWorkingTransitionSnapShot202002s { get; set; } = null!;
        public virtual DbSet<AndonCondition> AndonConditions { get; set; } = null!;
        public virtual DbSet<AndonCondition20190522> AndonCondition20190522s { get; set; } = null!;
        public virtual DbSet<AndonCondition20190524> AndonCondition20190524s { get; set; } = null!;
        public virtual DbSet<AndonHistory> AndonHistories { get; set; } = null!;
        public virtual DbSet<AndonTran> AndonTrans { get; set; } = null!;
        public virtual DbSet<Application> Applications { get; set; } = null!;
        public virtual DbSet<ApplicationObject> ApplicationObjects { get; set; } = null!;
        public virtual DbSet<AutoAndonAlarmTran> AutoAndonAlarmTrans { get; set; } = null!;
        public virtual DbSet<AutoAndonControlType> AutoAndonControlTypes { get; set; } = null!;
        public virtual DbSet<AutoAndonDefectCondition> AutoAndonDefectConditions { get; set; } = null!;
        public virtual DbSet<AutoAndonDefectCondition20221004> AutoAndonDefectCondition20221004s { get; set; } = null!;
        public virtual DbSet<AutoAndonDefectTran> AutoAndonDefectTrans { get; set; } = null!;
        public virtual DbSet<AutoAndonMaterialCondition> AutoAndonMaterialConditions { get; set; } = null!;
        public virtual DbSet<AutoAndonMaterialTimeExclusion> AutoAndonMaterialTimeExclusions { get; set; } = null!;
        public virtual DbSet<AutoAndonMaterialTran> AutoAndonMaterialTrans { get; set; } = null!;
        public virtual DbSet<AutoAndonPmstran> AutoAndonPmstrans { get; set; } = null!;
        public virtual DbSet<AutoAndonSpctran> AutoAndonSpctrans { get; set; } = null!;
        public virtual DbSet<AutoAndonTimeTran> AutoAndonTimeTrans { get; set; } = null!;
        public virtual DbSet<Boilicense> Boilicenses { get; set; } = null!;
        public virtual DbSet<Calendar> Calendars { get; set; } = null!;
        public virtual DbSet<Capa> Capas { get; set; } = null!;
        public virtual DbSet<Carrier> Carriers { get; set; } = null!;
        public virtual DbSet<CarrierCategory> CarrierCategories { get; set; } = null!;
        public virtual DbSet<CarrierMount> CarrierMounts { get; set; } = null!;
        public virtual DbSet<CarrierMountBefore20200801> CarrierMountBefore20200801s { get; set; } = null!;
        public virtual DbSet<CarrierMountWkTemp> CarrierMountWkTemps { get; set; } = null!;
        public virtual DbSet<CarrierNo> CarrierNos { get; set; } = null!;
        public virtual DbSet<CollateConbination> CollateConbinations { get; set; } = null!;
        public virtual DbSet<CurrentLoadCarrierInfo> CurrentLoadCarrierInfos { get; set; } = null!;
        public virtual DbSet<CycleCountUpForLotEnd> CycleCountUpForLotEnds { get; set; } = null!;
        public virtual DbSet<CycleTimeExclusion> CycleTimeExclusions { get; set; } = null!;
        public virtual DbSet<Defect> Defects { get; set; } = null!;
        public virtual DbSet<DefectAnalysis> DefectAnalyses { get; set; } = null!;
        public virtual DbSet<DefectAnalysisLot> DefectAnalysisLots { get; set; } = null!;
        public virtual DbSet<DefectGroup> DefectGroups { get; set; } = null!;
        public virtual DbSet<DisplayDetail> DisplayDetails { get; set; } = null!;
        public virtual DbSet<DisplayDetailSearchInfo> DisplayDetailSearchInfos { get; set; } = null!;
        public virtual DbSet<DisplayHeader> DisplayHeaders { get; set; } = null!;
        public virtual DbSet<EqpmaintenanceControl> EqpmaintenanceControls { get; set; } = null!;
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; } = null!;
        public virtual DbSet<ErrorLogBefore20200101> ErrorLogBefore20200101s { get; set; } = null!;
        public virtual DbSet<ExcludeNcimChecking> ExcludeNcimCheckings { get; set; } = null!;
        public virtual DbSet<FirstRegularOrderTran> FirstRegularOrderTrans { get; set; } = null!;
        public virtual DbSet<Flow> Flows { get; set; } = null!;
        public virtual DbSet<GraphComment> GraphComments { get; set; } = null!;
        public virtual DbSet<InputItem> InputItems { get; set; } = null!;
        public virtual DbSet<InputItemList> InputItemLists { get; set; } = null!;
        public virtual DbSet<InspectionReelHist> InspectionReelHists { get; set; } = null!;
        public virtual DbSet<InvalidAndonHistory> InvalidAndonHistories { get; set; } = null!;
        public virtual DbSet<InventoryCalendar> InventoryCalendars { get; set; } = null!;
        public virtual DbSet<ItemCategory> ItemCategories { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<Licence> Licences { get; set; } = null!;
        public virtual DbSet<LineGroup> LineGroups { get; set; } = null!;
        public virtual DbSet<LineM> LineMs { get; set; } = null!;
        public virtual DbSet<LineMachine> LineMachines { get; set; } = null!;
        public virtual DbSet<LineMachineTemp> LineMachineTemps { get; set; } = null!;
        public virtual DbSet<LineType> LineTypes { get; set; } = null!;
        public virtual DbSet<LotActualUnit> LotActualUnits { get; set; } = null!;
        public virtual DbSet<LotActualUnitTemp> LotActualUnitTemps { get; set; } = null!;
        public virtual DbSet<LotAlarm> LotAlarms { get; set; } = null!;
        public virtual DbSet<LotBlend> LotBlends { get; set; } = null!;
        public virtual DbSet<LotBlendDetail> LotBlendDetails { get; set; } = null!;
        public virtual DbSet<LotComment> LotComments { get; set; } = null!;
        public virtual DbSet<LotCommentBefore20200101> LotCommentBefore20200101s { get; set; } = null!;
        public virtual DbSet<LotCompleteHist> LotCompleteHists { get; set; } = null!;
        public virtual DbSet<LotDefect> LotDefects { get; set; } = null!;
        public virtual DbSet<LotDefectDetail> LotDefectDetails { get; set; } = null!;
        public virtual DbSet<LotDefectTemp> LotDefectTemps { get; set; } = null!;
        public virtual DbSet<LotInfo> LotInfos { get; set; } = null!;
        public virtual DbSet<LotInputControl> LotInputControls { get; set; } = null!;
        public virtual DbSet<LotInputControlTemp> LotInputControlTemps { get; set; } = null!;
        public virtual DbSet<LotMaterialDefect> LotMaterialDefects { get; set; } = null!;
        public virtual DbSet<LotMaterialProgress> LotMaterialProgresses { get; set; } = null!;
        public virtual DbSet<LotMaterialProgressTemp> LotMaterialProgressTemps { get; set; } = null!;
        public virtual DbSet<LotOperation> LotOperations { get; set; } = null!;
        public virtual DbSet<LotOperation20221024> LotOperation20221024s { get; set; } = null!;
        public virtual DbSet<LotOperationDetail> LotOperationDetails { get; set; } = null!;
        public virtual DbSet<LotOperationHistory> LotOperationHistories { get; set; } = null!;
        public virtual DbSet<LotOperationItem> LotOperationItems { get; set; } = null!;
        public virtual DbSet<LotOperationItem20221024> LotOperationItem20221024s { get; set; } = null!;
        public virtual DbSet<LotOperationItemDetail> LotOperationItemDetails { get; set; } = null!;
        public virtual DbSet<LotOperationItemHistory> LotOperationItemHistories { get; set; } = null!;
        public virtual DbSet<LotOutput> LotOutputs { get; set; } = null!;
        public virtual DbSet<LotProgress> LotProgresses { get; set; } = null!;
        public virtual DbSet<LotProgress20220906> LotProgress20220906s { get; set; } = null!;
        public virtual DbSet<LotProgressDetail> LotProgressDetails { get; set; } = null!;
        public virtual DbSet<LotProgressTemp> LotProgressTemps { get; set; } = null!;
        public virtual DbSet<LotSpecial> LotSpecials { get; set; } = null!;
        public virtual DbSet<LotSplitHistory> LotSplitHistories { get; set; } = null!;
        public virtual DbSet<LotTimeLimit> LotTimeLimits { get; set; } = null!;
        public virtual DbSet<LotTimeLimitTemp> LotTimeLimitTemps { get; set; } = null!;
        public virtual DbSet<LotZtcinstruction> LotZtcinstructions { get; set; } = null!;
        public virtual DbSet<LotZtcinstructionWkTemp> LotZtcinstructionWkTemps { get; set; } = null!;
        public virtual DbSet<LtprocessSnapShot> LtprocessSnapShots { get; set; } = null!;
        public virtual DbSet<LtsnapShot> LtsnapShots { get; set; } = null!;
        public virtual DbSet<Machine> Machines { get; set; } = null!;
        public virtual DbSet<MachineAlarmRpt> MachineAlarmRpts { get; set; } = null!;
        public virtual DbSet<MachineGroup> MachineGroups { get; set; } = null!;
        public virtual DbSet<MachineGroupProcess> MachineGroupProcesses { get; set; } = null!;
        public virtual DbSet<MachineMaintenance> MachineMaintenances { get; set; } = null!;
        public virtual DbSet<MachineMaintenanceBefore20200801> MachineMaintenanceBefore20200801s { get; set; } = null!;
        public virtual DbSet<MachineOperation> MachineOperations { get; set; } = null!;
        public virtual DbSet<MachineOperationLog> MachineOperationLogs { get; set; } = null!;
        public virtual DbSet<MachineProcess> MachineProcesses { get; set; } = null!;
        public virtual DbSet<MachineProduct> MachineProducts { get; set; } = null!;
        public virtual DbSet<MachineProductPlan> MachineProductPlans { get; set; } = null!;
        public virtual DbSet<MachineStatusRpt> MachineStatusRpts { get; set; } = null!;
        public virtual DbSet<MachineTemp> MachineTemps { get; set; } = null!;
        public virtual DbSet<MachineTemp201906> MachineTemp201906s { get; set; } = null!;
        public virtual DbSet<MailFormat> MailFormats { get; set; } = null!;
        public virtual DbSet<MaintenanceSystemLog> MaintenanceSystemLogs { get; set; } = null!;
        public virtual DbSet<MaintenanceSystemLogBefore20200101> MaintenanceSystemLogBefore20200101s { get; set; } = null!;
        public virtual DbSet<MaterialMachine> MaterialMachines { get; set; } = null!;
        public virtual DbSet<MaterialMount> MaterialMounts { get; set; } = null!;
        public virtual DbSet<MaterialMountBefore20200801> MaterialMountBefore20200801s { get; set; } = null!;
        public virtual DbSet<MaterialMountTemp> MaterialMountTemps { get; set; } = null!;
        public virtual DbSet<MaterialMountTemp201906> MaterialMountTemp201906s { get; set; } = null!;
        public virtual DbSet<MaterialMountVerupTemp> MaterialMountVerupTemps { get; set; } = null!;
        public virtual DbSet<MaterialProcessFlow> MaterialProcessFlows { get; set; } = null!;
        public virtual DbSet<MaterialSpecification> MaterialSpecifications { get; set; } = null!;
        public virtual DbSet<MmaterialLot> MmaterialLots { get; set; } = null!;
        public virtual DbSet<MmaterialLotBak20161114> MmaterialLotBak20161114s { get; set; } = null!;
        public virtual DbSet<MmaterialLotBak20170131> MmaterialLotBak20170131s { get; set; } = null!;
        public virtual DbSet<MmaterialLotBak20710530> MmaterialLotBak20710530s { get; set; } = null!;
        public virtual DbSet<MonitoringTarget> MonitoringTargets { get; set; } = null!;
        public virtual DbSet<NcimMenuItem> NcimMenuItems { get; set; } = null!;
        public virtual DbSet<NcimOutputControl> NcimOutputControls { get; set; } = null!;
        public virtual DbSet<NcimRemoteControl> NcimRemoteControls { get; set; } = null!;
        public virtual DbSet<NcimTerminalControl> NcimTerminalControls { get; set; } = null!;
        public virtual DbSet<NcimTerminalMenu> NcimTerminalMenus { get; set; } = null!;
        public virtual DbSet<NcimToEqpif> NcimToEqpifs { get; set; } = null!;
        public virtual DbSet<Operation> Operations { get; set; } = null!;
        public virtual DbSet<OperationCycleCtrl> OperationCycleCtrls { get; set; } = null!;
        public virtual DbSet<OperationCycleCtrl20200707> OperationCycleCtrl20200707s { get; set; } = null!;
        public virtual DbSet<OperationCycleCtrlBk> OperationCycleCtrlBks { get; set; } = null!;
        public virtual DbSet<OperationCycleTran> OperationCycleTrans { get; set; } = null!;
        public virtual DbSet<OperationGroup> OperationGroups { get; set; } = null!;
        public virtual DbSet<OperationGroupTemp> OperationGroupTemps { get; set; } = null!;
        public virtual DbSet<OperationItemCateg> OperationItemCategs { get; set; } = null!;
        public virtual DbSet<OperationTact> OperationTacts { get; set; } = null!;
        public virtual DbSet<OperationTran> OperationTrans { get; set; } = null!;
        public virtual DbSet<OperationTrans20161215> OperationTrans20161215s { get; set; } = null!;
        public virtual DbSet<OperationTransBefore20200101> OperationTransBefore20200101s { get; set; } = null!;
        public virtual DbSet<OperationWebApi> OperationWebApis { get; set; } = null!;
        public virtual DbSet<Operator> Operators { get; set; } = null!;
        public virtual DbSet<OperatorRole> OperatorRoles { get; set; } = null!;
        public virtual DbSet<Output> Outputs { get; set; } = null!;
        public virtual DbSet<OutputGroup> OutputGroups { get; set; } = null!;
        public virtual DbSet<Priority> Priorities { get; set; } = null!;
        public virtual DbSet<Process> Processes { get; set; } = null!;
        public virtual DbSet<ProcessArrange> ProcessArranges { get; set; } = null!;
        public virtual DbSet<ProcessCalendar> ProcessCalendars { get; set; } = null!;
        public virtual DbSet<ProcessDefect> ProcessDefects { get; set; } = null!;
        public virtual DbSet<ProcessDefectRelation> ProcessDefectRelations { get; set; } = null!;
        public virtual DbSet<ProcessFlow> ProcessFlows { get; set; } = null!;
        public virtual DbSet<ProcessGroup> ProcessGroups { get; set; } = null!;
        public virtual DbSet<ProcessOutput> ProcessOutputs { get; set; } = null!;
        public virtual DbSet<ProcessStartEndControl> ProcessStartEndControls { get; set; } = null!;
        public virtual DbSet<ProductCarrier> ProductCarriers { get; set; } = null!;
        public virtual DbSet<ProductComment> ProductComments { get; set; } = null!;
        public virtual DbSet<ProductDetailPlan> ProductDetailPlans { get; set; } = null!;
        public virtual DbSet<ProductFlow> ProductFlows { get; set; } = null!;
        public virtual DbSet<ProductGroup> ProductGroups { get; set; } = null!;
        public virtual DbSet<ProductMachine> ProductMachines { get; set; } = null!;
        public virtual DbSet<ProductMaterial> ProductMaterials { get; set; } = null!;
        public virtual DbSet<ProductMaterialDf20221111> ProductMaterialDf20221111s { get; set; } = null!;
        public virtual DbSet<ProductMaterialTemp> ProductMaterialTemps { get; set; } = null!;
        public virtual DbSet<ProductPlan> ProductPlans { get; set; } = null!;
        public virtual DbSet<ProductPlanBefore20200101> ProductPlanBefore20200101s { get; set; } = null!;
        public virtual DbSet<ProductTool> ProductTools { get; set; } = null!;
        public virtual DbSet<ProductToolBk> ProductToolBks { get; set; } = null!;
        public virtual DbSet<ProductToolDf20221111> ProductToolDf20221111s { get; set; } = null!;
        public virtual DbSet<ProductToolDf202211111> ProductToolDf20221111s1 { get; set; } = null!;
        public virtual DbSet<ProductToolTemp> ProductToolTemps { get; set; } = null!;
        public virtual DbSet<ProductUnContinuou> ProductUnContinuous { get; set; } = null!;
        public virtual DbSet<ProductUnContinuousGroup> ProductUnContinuousGroups { get; set; } = null!;
        public virtual DbSet<ProductlUnContinuou> ProductlUnContinuous { get; set; } = null!;
        public virtual DbSet<Profilelog> Profilelogs { get; set; } = null!;
        public virtual DbSet<Profilelog1> Profilelogs1 { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RoleObject> RoleObjects { get; set; } = null!;
        public virtual DbSet<RpmImport> RpmImports { get; set; } = null!;
        public virtual DbSet<SerialMaster> SerialMasters { get; set; } = null!;
        public virtual DbSet<SerialTimeLimit> SerialTimeLimits { get; set; } = null!;
        public virtual DbSet<ShiftCalendar> ShiftCalendars { get; set; } = null!;
        public virtual DbSet<SmallProcLotDefect> SmallProcLotDefects { get; set; } = null!;
        public virtual DbSet<SmallProcProgress> SmallProcProgresses { get; set; } = null!;
        public virtual DbSet<SmallProcessFlow> SmallProcessFlows { get; set; } = null!;
        public virtual DbSet<StandardUnit> StandardUnits { get; set; } = null!;
        public virtual DbSet<Status> Statuses { get; set; } = null!;
        public virtual DbSet<SupplementItem> SupplementItems { get; set; } = null!;
        public virtual DbSet<SupplementItemBefore20200101> SupplementItemBefore20200101s { get; set; } = null!;
        public virtual DbSet<SupplementItemCateg> SupplementItemCategs { get; set; } = null!;
        public virtual DbSet<SupplementItemDetail> SupplementItemDetails { get; set; } = null!;
        public virtual DbSet<SupplementItemDetail20200101> SupplementItemDetail20200101s { get; set; } = null!;
        public virtual DbSet<SynonymCarrierMap> SynonymCarrierMaps { get; set; } = null!;
        public virtual DbSet<SysVerControl> SysVerControls { get; set; } = null!;
        public virtual DbSet<SystemSetting> SystemSettings { get; set; } = null!;
        public virtual DbSet<TWorkLt> TWorkLts { get; set; } = null!;
        public virtual DbSet<Tact> Tacts { get; set; } = null!;
        public virtual DbSet<TblBq> TblBqs { get; set; } = null!;
        public virtual DbSet<TblBqclass> TblBqclasses { get; set; } = null!;
        public virtual DbSet<TblBqclassDaoDv> TblBqclassDaoDvs { get; set; } = null!;
        public virtual DbSet<TblBqitem> TblBqitems { get; set; } = null!;
        public virtual DbSet<TblBqtable> TblBqtables { get; set; } = null!;
        public virtual DbSet<TblBqtableMonth> TblBqtableMonths { get; set; } = null!;
        public virtual DbSet<TblBqtableMonthNoInput> TblBqtableMonthNoInputs { get; set; } = null!;
        public virtual DbSet<TblBqtempDailyDetail> TblBqtempDailyDetails { get; set; } = null!;
        public virtual DbSet<TblBqtempMonthDetail> TblBqtempMonthDetails { get; set; } = null!;
        public virtual DbSet<TblBqunLockTran> TblBqunLockTrans { get; set; } = null!;
        public virtual DbSet<TblMachineRunList> TblMachineRunLists { get; set; } = null!;
        public virtual DbSet<Testinsert> Testinserts { get; set; } = null!;
        public virtual DbSet<TimeLimitControl> TimeLimitControls { get; set; } = null!;
        public virtual DbSet<TimeZone> TimeZones { get; set; } = null!;
        public virtual DbSet<Tool> Tools { get; set; } = null!;
        public virtual DbSet<ToolCategory> ToolCategories { get; set; } = null!;
        public virtual DbSet<ToolId> ToolIds { get; set; } = null!;
        public virtual DbSet<ToolMount> ToolMounts { get; set; } = null!;
        public virtual DbSet<ToolMountBefore20200801> ToolMountBefore20200801s { get; set; } = null!;
        public virtual DbSet<ToolMountBk> ToolMountBks { get; set; } = null!;
        public virtual DbSet<ToolMountT002Capillary> ToolMountT002Capillaries { get; set; } = null!;
        public virtual DbSet<ToolMountTemp> ToolMountTemps { get; set; } = null!;
        public virtual DbSet<TtldefectiveRateSnapShot> TtldefectiveRateSnapShots { get; set; } = null!;
        public virtual DbSet<TtldefectiveRateSnapShotOld> TtldefectiveRateSnapShotOlds { get; set; } = null!;
        public virtual DbSet<TtldefectiveRateUnscrapSnapShot> TtldefectiveRateUnscrapSnapShots { get; set; } = null!;
        public virtual DbSet<TypeGroup> TypeGroups { get; set; } = null!;
        public virtual DbSet<TypeProductProcess> TypeProductProcesses { get; set; } = null!;
        public virtual DbSet<Umt3rpm> Umt3rpms { get; set; } = null!;
        public virtual DbSet<UnProducingTime> UnProducingTimes { get; set; } = null!;
        public virtual DbSet<Unit> Units { get; set; } = null!;
        public virtual DbSet<ValueList> ValueLists { get; set; } = null!;
        public virtual DbSet<VewAlllotProgress> VewAlllotProgresses { get; set; } = null!;
        public virtual DbSet<VewAnalysisSheet> VewAnalysisSheets { get; set; } = null!;
        public virtual DbSet<VewAndonHistory> VewAndonHistories { get; set; } = null!;
        public virtual DbSet<VewBlendLotInfo> VewBlendLotInfos { get; set; } = null!;
        public virtual DbSet<VewConversionUnit> VewConversionUnits { get; set; } = null!;
        public virtual DbSet<VewDefect> VewDefects { get; set; } = null!;
        public virtual DbSet<VewDefectDetail> VewDefectDetails { get; set; } = null!;
        public virtual DbSet<VewDefectLotDetail> VewDefectLotDetails { get; set; } = null!;
        public virtual DbSet<VewDefectLotInq> VewDefectLotInqs { get; set; } = null!;
        public virtual DbSet<VewGetLotItemDeviceCheck> VewGetLotItemDeviceChecks { get; set; } = null!;
        public virtual DbSet<VewGetMachineSupplement> VewGetMachineSupplements { get; set; } = null!;
        public virtual DbSet<VewGetMaterialMounts01> VewGetMaterialMounts01s { get; set; } = null!;
        public virtual DbSet<VewGetMaterialSupplement> VewGetMaterialSupplements { get; set; } = null!;
        public virtual DbSet<VewGetToolSupplement> VewGetToolSupplements { get; set; } = null!;
        public virtual DbSet<VewGetlotProgressMaterialMount> VewGetlotProgressMaterialMounts { get; set; } = null!;
        public virtual DbSet<VewInfoLotMaterial> VewInfoLotMaterials { get; set; } = null!;
        public virtual DbSet<VewInfoLotMaterialDetail> VewInfoLotMaterialDetails { get; set; } = null!;
        public virtual DbSet<VewInfoLotTool> VewInfoLotTools { get; set; } = null!;
        public virtual DbSet<VewInfoLotToolDetail> VewInfoLotToolDetails { get; set; } = null!;
        public virtual DbSet<VewInfoLotTrouble> VewInfoLotTroubles { get; set; } = null!;
        public virtual DbSet<VewInfomationItem> VewInfomationItems { get; set; } = null!;
        public virtual DbSet<VewLeadTimeSec> VewLeadTimeSecs { get; set; } = null!;
        public virtual DbSet<VewLineFirstMachineNo> VewLineFirstMachineNos { get; set; } = null!;
        public virtual DbSet<VewLineMachineType> VewLineMachineTypes { get; set; } = null!;
        public virtual DbSet<VewLotDefectDetail> VewLotDefectDetails { get; set; } = null!;
        public virtual DbSet<VewLotDefectDetailChild> VewLotDefectDetailChildren { get; set; } = null!;
        public virtual DbSet<VewLotDefectListFl330> VewLotDefectListFl330s { get; set; } = null!;
        public virtual DbSet<VewLotDefectParamInfo> VewLotDefectParamInfos { get; set; } = null!;
        public virtual DbSet<VewLotDefectParamInfoChild> VewLotDefectParamInfoChildren { get; set; } = null!;
        public virtual DbSet<VewLotItemList> VewLotItemLists { get; set; } = null!;
        public virtual DbSet<VewLotItemListDeviceCheck> VewLotItemListDeviceChecks { get; set; } = null!;
        public virtual DbSet<VewLotMaterialHistory> VewLotMaterialHistories { get; set; } = null!;
        public virtual DbSet<VewLotMaterialTool> VewLotMaterialTools { get; set; } = null!;
        public virtual DbSet<VewLotOperationItemCheck> VewLotOperationItemChecks { get; set; } = null!;
        public virtual DbSet<VewLotProgress> VewLotProgresses { get; set; } = null!;
        public virtual DbSet<VewLotProgressForLt> VewLotProgressForLts { get; set; } = null!;
        public virtual DbSet<VewLotProgressForLt20180329> VewLotProgressForLt20180329s { get; set; } = null!;
        public virtual DbSet<VewLotProgressMaterialToolMount> VewLotProgressMaterialToolMounts { get; set; } = null!;
        public virtual DbSet<VewLotResult> VewLotResults { get; set; } = null!;
        public virtual DbSet<VewLotResultProdQtyMatLedger> VewLotResultProdQtyMatLedgers { get; set; } = null!;
        public virtual DbSet<VewLotSplitHistory> VewLotSplitHistories { get; set; } = null!;
        public virtual DbSet<VewLotStopLine> VewLotStopLines { get; set; } = null!;
        public virtual DbSet<VewLotTimeLimitResult> VewLotTimeLimitResults { get; set; } = null!;
        public virtual DbSet<VewMachine> VewMachines { get; set; } = null!;
        public virtual DbSet<VewMachineMonitoring> VewMachineMonitorings { get; set; } = null!;
        public virtual DbSet<VewMaterial> VewMaterials { get; set; } = null!;
        public virtual DbSet<VewMaterialBak20180607> VewMaterialBak20180607s { get; set; } = null!;
        public virtual DbSet<VewMatomeLot> VewMatomeLots { get; set; } = null!;
        public virtual DbSet<VewMlc21lot> VewMlc21lots { get; set; } = null!;
        public virtual DbSet<VewOperation> VewOperations { get; set; } = null!;
        public virtual DbSet<VewOperatorRoleApplication> VewOperatorRoleApplications { get; set; } = null!;
        public virtual DbSet<VewOperatorRoleObject> VewOperatorRoleObjects { get; set; } = null!;
        public virtual DbSet<VewPrdEndProcess> VewPrdEndProcesses { get; set; } = null!;
        public virtual DbSet<VewProcess> VewProcesses { get; set; } = null!;
        public virtual DbSet<VewProcessFlow> VewProcessFlows { get; set; } = null!;
        public virtual DbSet<VewProductRoute> VewProductRoutes { get; set; } = null!;
        public virtual DbSet<VewProductionStatus> VewProductionStatuses { get; set; } = null!;
        public virtual DbSet<VewProductionStatusBk> VewProductionStatusBks { get; set; } = null!;
        public virtual DbSet<VewProductionStatusTest> VewProductionStatusTests { get; set; } = null!;
        public virtual DbSet<VewReferenceLot> VewReferenceLots { get; set; } = null!;
        public virtual DbSet<VewReprintProductLabelHist> VewReprintProductLabelHists { get; set; } = null!;
        public virtual DbSet<VewSerialTimeLimitResult> VewSerialTimeLimitResults { get; set; } = null!;
        public virtual DbSet<VewSupplementItem> VewSupplementItems { get; set; } = null!;
        public virtual DbSet<VewSupplementItemBk20191218> VewSupplementItemBk20191218s { get; set; } = null!;
        public virtual DbSet<VewSynonymlot> VewSynonymlots { get; set; } = null!;
        public virtual DbSet<VewTenkenMaintenance> VewTenkenMaintenances { get; set; } = null!;
        public virtual DbSet<VewTypeGroup> VewTypeGroups { get; set; } = null!;
        public virtual DbSet<VewTypeGroupProduct> VewTypeGroupProducts { get; set; } = null!;
        public virtual DbSet<VewTypeNcim> VewTypeNcims { get; set; } = null!;
        public virtual DbSet<VewUnApproveCheckAll> VewUnApproveCheckAlls { get; set; } = null!;
        public virtual DbSet<VewUnitPrice> VewUnitPrices { get; set; } = null!;
        public virtual DbSet<VewWipLot> VewWipLots { get; set; } = null!;
        public virtual DbSet<VewWipLotForFifo> VewWipLotForFifos { get; set; } = null!;
        public virtual DbSet<VewWipLotForPoc> VewWipLotForPocs { get; set; } = null!;
        public virtual DbSet<VewWipLotReference> VewWipLotReferences { get; set; } = null!;
        public virtual DbSet<VewWipLotReferenceBak20161108> VewWipLotReferenceBak20161108s { get; set; } = null!;
        public virtual DbSet<VewWipLotReferenceBak20200402> VewWipLotReferenceBak20200402s { get; set; } = null!;
        public virtual DbSet<VewWiplotSummary> VewWiplotSummaries { get; set; } = null!;
        public virtual DbSet<VewWipmonitoring> VewWipmonitorings { get; set; } = null!;
        public virtual DbSet<VewWipprevLot> VewWipprevLots { get; set; } = null!;
        public virtual DbSet<VewXrayFifo> VewXrayFifos { get; set; } = null!;
        public virtual DbSet<VewZchart> VewZcharts { get; set; } = null!;
        public virtual DbSet<View1> View1s { get; set; } = null!;
        public virtual DbSet<View2> View2s { get; set; } = null!;
        public virtual DbSet<WebApiparameter> WebApiparameters { get; set; } = null!;
        public virtual DbSet<WipControlProductCateg> WipControlProductCategs { get; set; } = null!;
        public virtual DbSet<WipProcessControl> WipProcessControls { get; set; } = null!;
        public virtual DbSet<Wipmonitoring> Wipmonitorings { get; set; } = null!;
        public virtual DbSet<WipmonitoringSnapShot> WipmonitoringSnapShots { get; set; } = null!;
        public virtual DbSet<WipsnapShot> WipsnapShots { get; set; } = null!;
        public virtual DbSet<WsrouteNo> WsrouteNos { get; set; } = null!;
        public virtual DbSet<ZLottraceDelete> ZLottraceDeletes { get; set; } = null!;
        public virtual DbSet<ZLottraceDeleteRecovery> ZLottraceDeleteRecoveries { get; set; } = null!;
        public virtual DbSet<ZLottraceLotDefectMpt3> ZLottraceLotDefectMpt3s { get; set; } = null!;
        public virtual DbSet<ZLottraceLotDefectMpt3mc> ZLottraceLotDefectMpt3mcs { get; set; } = null!;
        public virtual DbSet<ZLottraceLotResultMpt3> ZLottraceLotResultMpt3s { get; set; } = null!;
        public virtual DbSet<ZLottraceLotResultMpt3mc> ZLottraceLotResultMpt3mcs { get; set; } = null!;
        public virtual DbSet<ZMmaterialLotWafer> ZMmaterialLotWafers { get; set; } = null!;
        public virtual DbSet<ZOperationItemCateg20210816> ZOperationItemCateg20210816s { get; set; } = null!;
        public virtual DbSet<ZProductFlow> ZProductFlows { get; set; } = null!;
        public virtual DbSet<ZVewProductMaster> ZVewProductMasters { get; set; } = null!;
        public virtual DbSet<ZtccountUpForLotEnd> ZtccountUpForLotEnds { get; set; } = null!;
        public virtual DbSet<ZtclimitCtrl> ZtclimitCtrls { get; set; } = null!;
        public virtual DbSet<ZtclimitTran> ZtclimitTrans { get; set; } = null!;
        public virtual DbSet<ZvewMasterDeviceCheck> ZvewMasterDeviceChecks { get; set; } = null!;
        public virtual DbSet<ZvewMasterSupplementCheck> ZvewMasterSupplementChecks { get; set; } = null!;
        public virtual DbSet<ZvewWacollationNcim> ZvewWacollationNcims { get; set; } = null!;
        public virtual DbSet<ZvewWacollationNcimCount> ZvewWacollationNcimCounts { get; set; } = null!;
        public virtual DbSet<ZzCheckDeviceCheckOtherProcess> ZzCheckDeviceCheckOtherProcesses { get; set; } = null!;
        public virtual DbSet<ZzCheckMiddleProcess> ZzCheckMiddleProcesses { get; set; } = null!;
        public virtual DbSet<ZzCheckProcessnameNotShowLotmatenance> ZzCheckProcessnameNotShowLotmatenances { get; set; } = null!;
        public virtual DbSet<ZzLineM> ZzLineMs { get; set; } = null!;
        public virtual DbSet<ZzLineMachineW010> ZzLineMachineW010s { get; set; } = null!;
        public virtual DbSet<ZzMachine> ZzMachines { get; set; } = null!;
        public virtual DbSet<ZzMachineResin> ZzMachineResins { get; set; } = null!;
        public virtual DbSet<ZzMaterialToolResin> ZzMaterialToolResins { get; set; } = null!;
        public virtual DbSet<ZzMcPowerLine> ZzMcPowerLines { get; set; } = null!;
        public virtual DbSet<ZzMcToSeries> ZzMcToSeries { get; set; } = null!;
        public virtual DbSet<ZzProcessFlowSti> ZzProcessFlowStis { get; set; } = null!;
        public virtual DbSet<ZzProcessPower> ZzProcessPowers { get; set; } = null!;
        public virtual DbSet<ZzProductFlowTemp> ZzProductFlowTemps { get; set; } = null!;
        public virtual DbSet<ZzProductPlanSummaryGroup> ZzProductPlanSummaryGroups { get; set; } = null!;
        public virtual DbSet<ZzSupplementItemCateg> ZzSupplementItemCategs { get; set; } = null!;
        public virtual DbSet<ZzSupplementItemCategMaking> ZzSupplementItemCategMakings { get; set; } = null!;
        public virtual DbSet<ZzTempLot> ZzTempLots { get; set; } = null!;
        public virtual DbSet<ZzTypeGroup> ZzTypeGroups { get; set; } = null!;
        public virtual DbSet<ZzprocessFlow> ZzprocessFlows { get; set; } = null!;
        public virtual DbSet<ZzvewCreateLotCommentForFinal> ZzvewCreateLotCommentForFinals { get; set; } = null!;
        public virtual DbSet<Zzvewproductcategory> Zzvewproductcategories { get; set; } = null!;
        public virtual DbSet<ZzzCheckLinegrouidIsnull> ZzzCheckLinegrouidIsnulls { get; set; } = null!;
        public virtual DbSet<ZzzEmbossStock> ZzzEmbossStocks { get; set; } = null!;
        public virtual DbSet<ZzzMaxSeqNo> ZzzMaxSeqNos { get; set; } = null!;
        public virtual DbSet<ZzzProcessSuspendedBlocking> ZzzProcessSuspendedBlockings { get; set; } = null!;
        public virtual DbSet<ZzzProductRouteTrpi> ZzzProductRouteTrpis { get; set; } = null!;
        public virtual DbSet<ZzzSeqNoZero> ZzzSeqNoZeros { get; set; } = null!;
        public virtual DbSet<ZzzTypeGroup> ZzzTypeGroups { get; set; } = null!;
        public virtual DbSet<ZzzUpdM002sForMkAnalysis> ZzzUpdM002sForMkAnalyses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=RTHSRVTR02;Database=TRProcessControl;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Abnormal>(entity =>
            {
                entity.HasKey(e => e.AbnormalCode);

                entity.ToTable("Abnormal");

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AbnormalName).HasMaxLength(50);

                entity.Property(e => e.AbnormalRegistration)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AndonHistory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ncn)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("NCN")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.SystemTrigger)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AbnormalLot>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.AbnormalNo });

                entity.ToTable("AbnormalLot");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AbnormalName).HasMaxLength(50);

                entity.Property(e => e.AbnormalReason).HasMaxLength(800);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AutoAndonTranId).HasColumnName("AutoAndonTranID");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress")
                    .IsFixedLength();

                entity.Property(e => e.LatestComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LatestUpdDate).HasColumnType("datetime");

                entity.Property(e => e.LatestUpdOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LatestUpdOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.LatestUpdOperatorName).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.RegistComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistDate).HasColumnType("datetime");

                entity.Property(e => e.RegistOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RegistOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.RegistOperatorName).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(1024);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AbnormalLotTran>(entity =>
            {
                entity.HasKey(e => e.TranId);

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AbnormalReason).HasMaxLength(800);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AutoAndonTranId).HasColumnName("AutoAndonTranID");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress")
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Remarks).HasMaxLength(1024);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AbnormalSerial>(entity =>
            {
                entity.HasKey(e => new { e.SerialNo, e.LotNo, e.LotNoSuffix, e.AbnormalNo });

                entity.ToTable("AbnormalSerial");

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AbnormalName).HasMaxLength(50);

                entity.Property(e => e.AbnormalReason).HasMaxLength(256);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AutoAndonTranId).HasColumnName("AutoAndonTranID");

                entity.Property(e => e.CarrierNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress")
                    .IsFixedLength();

                entity.Property(e => e.LatestComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LatestUpdDate).HasColumnType("datetime");

                entity.Property(e => e.LatestUpdOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("LatestUpdOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.LatestUpdOperatorName).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.RegistComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistDate).HasColumnType("datetime");

                entity.Property(e => e.RegistOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RegistOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.RegistOperatorName).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(1024);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AbnormalSerialTran>(entity =>
            {
                entity.HasKey(e => e.TranId);

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AbnormalReason).HasMaxLength(256);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AutoAndonTranId).HasColumnName("AutoAndonTranID");

                entity.Property(e => e.CarrierNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress")
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationDate).HasColumnType("datetime");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Remarks).HasMaxLength(1024);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AbnormalTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Abnormal_Temp");

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AbnormalName).HasMaxLength(50);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AndonHistory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SystemTrigger)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActualWorkingSnapShot>(entity =>
            {
                entity.HasKey(e => new { e.ActualWorkingDate, e.SummaryGroupCode, e.ParentSummaryGroupCode, e.MachineNo });

                entity.ToTable("ActualWorkingSnapShot");

                entity.Property(e => e.ActualWorkingDate).HasColumnType("date");

                entity.Property(e => e.SummaryGroupCode)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParentSummaryGroupCode)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpeGroupCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductionStartTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SummaryGroupName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActualWorkingSnapShot202002>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActualWorkingSnapShot_202002");

                entity.Property(e => e.ActualWorkingDate).HasColumnType("date");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductionStartTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SummaryGroupCode)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SummaryGroupName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActualWorkingSummaryCondition>(entity =>
            {
                entity.HasKey(e => e.ActualWorkingConditionId);

                entity.ToTable("ActualWorkingSummaryCondition");

                entity.HasIndex(e => new { e.SummaryGroupCode, e.OperationGroupMode, e.OperationGroup, e.StartOperationGroup, e.EndOperationGroup, e.IncludeOperationGroup }, "IX_ActualWorkingSummaryCondition")
                    .IsUnique();

                entity.Property(e => e.ActualWorkingConditionId).HasColumnName("ActualWorkingConditionID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperationGroup)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.IncludeOperationGroup)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationGroup)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationGroupMode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartEndFlagE)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartEndFlagS)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperationGroup)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SummaryGroupCode)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActualWorkingSummaryGroup>(entity =>
            {
                entity.HasKey(e => e.SummaryGroupCode);

                entity.ToTable("ActualWorkingSummaryGroup");

                entity.HasIndex(e => new { e.SummaryGroupName, e.ActualWorkingType }, "IX_ActualWorkingSummaryGroup")
                    .IsUnique();

                entity.Property(e => e.SummaryGroupCode)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualWorkingColor)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualWorkingType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OpeGroupCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParentSummaryGroupCode)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SummaryGroupName).HasMaxLength(40);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActualWorkingTransitionSnapShot>(entity =>
            {
                entity.HasKey(e => new { e.ActualWorkingDate, e.SeriesDataIndex, e.SummaryGroupCode, e.MachineNo });

                entity.ToTable("ActualWorkingTransitionSnapShot");

                entity.Property(e => e.ActualWorkingDate).HasColumnType("date");

                entity.Property(e => e.SummaryGroupCode)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParentSummaryGroupCode)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SummaryGroupName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ActualWorkingTransitionSnapShot202002>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ActualWorkingTransitionSnapShot_202002");

                entity.Property(e => e.ActualWorkingDate).HasColumnType("date");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SummaryGroupCode)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SummaryGroupName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AndonCondition>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode, e.ProductCateg, e.ProcessCode, e.MachineNo, e.DefectCode });

                entity.ToTable("AndonCondition");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCondition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PopulationParam)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Threshold).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AndonCondition20190522>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AndonCondition_20190522");

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCondition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PopulationParam)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Threshold).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AndonCondition20190524>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AndonCondition_20190524");

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCondition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PopulationParam)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Threshold).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AndonHistory>(entity =>
            {
                entity.HasKey(e => e.SeqNo)
                    .IsClustered(false);

                entity.ToTable("AndonHistory");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress")
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Memo).HasMaxLength(40);

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.PlaceOfUse).HasMaxLength(20);

                entity.Property(e => e.TerminalName).HasMaxLength(40);

                entity.Property(e => e.TerminalType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AndonTran>(entity =>
            {
                entity.HasKey(e => e.TranId);

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualDefectRate).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AndonCommt).HasMaxLength(255);

                entity.Property(e => e.AndonTime).HasColumnType("datetime");

                entity.Property(e => e.CheckEndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckEndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckEndOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckEndTime).HasColumnType("datetime");

                entity.Property(e => e.CheckStartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckStartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckStartOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckStartTime).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCondition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectName).HasMaxLength(20);

                entity.Property(e => e.DocumentPath).HasMaxLength(1024);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PopulationParam)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Threshold).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Application>(entity =>
            {
                entity.HasKey(e => e.ApplicationName);

                entity.ToTable("Application");

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ApplicationObject>(entity =>
            {
                entity.HasKey(e => new { e.ApplicationName, e.Object });

                entity.ToTable("ApplicationObject");

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Object)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoAndonAlarmTran>(entity =>
            {
                entity.HasKey(e => e.TranId);

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AlarmCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AlarmLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AlarmName).HasMaxLength(20);

                entity.Property(e => e.AndonCommt).HasMaxLength(255);

                entity.Property(e => e.AndonRegister)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.AndonTime).HasColumnType("datetime");

                entity.Property(e => e.CheckEndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckEndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckEndOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckEndTime).HasColumnType("datetime");

                entity.Property(e => e.CheckStartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckStartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckStartOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckStartTime).HasColumnType("datetime");

                entity.Property(e => e.CommentRank)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ControlType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DocumentPath).HasMaxLength(1024);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineModel)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StageName).HasMaxLength(100);

                entity.Property(e => e.Threshold).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoAndonControlType>(entity =>
            {
                entity.HasKey(e => new { e.ControlType, e.AndonTarget });

                entity.ToTable("AutoAndonControlType");

                entity.Property(e => e.ControlType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AndonTarget)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlTypeColor)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ControlTypeName).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoAndonDefectCondition>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode, e.ProductCateg, e.ProcessCode, e.MachineNo, e.DefectCode, e.Sign });

                entity.ToTable("AutoAndonDefectCondition");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Abnormal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCondition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PopulationParam)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Threshold).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoAndonDefectCondition20221004>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AutoAndonDefectCondition_20221004");

                entity.Property(e => e.Abnormal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCondition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PopulationParam)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Threshold).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoAndonDefectTran>(entity =>
            {
                entity.HasKey(e => e.TranId);

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualDefectRate).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AndonCommt).HasMaxLength(255);

                entity.Property(e => e.AndonRegister)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.AndonTime).HasColumnType("datetime");

                entity.Property(e => e.CheckEndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckEndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckEndOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckEndTime).HasColumnType("datetime");

                entity.Property(e => e.CheckStartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckStartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckStartOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckStartTime).HasColumnType("datetime");

                entity.Property(e => e.CommentRank)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionNo)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCondition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectName).HasMaxLength(20);

                entity.Property(e => e.DocumentPath).HasMaxLength(1024);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PopulationParam)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Threshold).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoAndonMaterialCondition>(entity =>
            {
                entity.HasKey(e => e.ConditionId);

                entity.ToTable("AutoAndonMaterialCondition");

                entity.Property(e => e.ConditionId)
                    .ValueGeneratedNever()
                    .HasColumnName("ConditionID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AddressGroup)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_GROUP")
                    .IsFixedLength();

                entity.Property(e => e.BaseResult).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionName).HasMaxLength(30);

                entity.Property(e => e.ControlType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromLocation)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromWarehouse)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromWarehouseName).HasMaxLength(30);

                entity.Property(e => e.MailFormat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.MailFormatCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.MailSend)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCondition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.MaterialStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.MoveLocation)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MoveWarehouse)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MoveWarehouseName).HasMaxLength(30);

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialCondition)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Threshold).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.ToLocation)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToWarehouse)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToWarehouseName).HasMaxLength(30);

                entity.Property(e => e.Unit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoAndonMaterialTimeExclusion>(entity =>
            {
                entity.HasKey(e => e.ConditionId);

                entity.ToTable("AutoAndonMaterialTimeExclusion");

                entity.Property(e => e.ConditionId)
                    .ValueGeneratedNever()
                    .HasColumnName("ConditionID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoAndonMaterialTran>(entity =>
            {
                entity.HasKey(e => e.TranId);

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.ActualResult).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AddressGroup)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS_GROUP")
                    .IsFixedLength();

                entity.Property(e => e.AndonCommt).HasMaxLength(255);

                entity.Property(e => e.AndonTime).HasColumnType("datetime");

                entity.Property(e => e.BaseResult).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.CheckEndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckEndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckEndOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckEndTime).HasColumnType("datetime");

                entity.Property(e => e.CheckStartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckStartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckStartOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckStartTime).HasColumnType("datetime");

                entity.Property(e => e.CommentRank)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionId).HasColumnName("ConditionID");

                entity.Property(e => e.ControlLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ControlLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ControlName).HasMaxLength(20);

                entity.Property(e => e.ControlType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DifferenceRate).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.DifferenceResult).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.DocumentPath).HasMaxLength(1024);

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.FromLocation)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromWarehouse)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromWarehouseName).HasMaxLength(30);

                entity.Property(e => e.InventoryDate).HasColumnType("date");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MailFormat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.MailFormatCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.MailSend)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCondition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.MaterialStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Threshold).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.ToLocation)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToWarehouse)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToWarehouseName).HasMaxLength(30);

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.Unit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoAndonPmstran>(entity =>
            {
                entity.HasKey(e => e.TranId);

                entity.ToTable("AutoAndonPMSTrans");

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AndonCommt).HasMaxLength(255);

                entity.Property(e => e.AndonRegister)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.AndonTime).HasColumnType("datetime");

                entity.Property(e => e.CalParamName).HasMaxLength(15);

                entity.Property(e => e.CheckEndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckEndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckEndOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckEndTime).HasColumnType("datetime");

                entity.Property(e => e.CheckStartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckStartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckStartOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckStartTime).HasColumnType("datetime");

                entity.Property(e => e.CommentRank)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentPath).HasMaxLength(1024);

                entity.Property(e => e.GraphUrl)
                    .HasMaxLength(1024)
                    .HasColumnName("GraphURL");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.JudgementDetail).HasMaxLength(500);

                entity.Property(e => e.Lacl)
                    .HasColumnType("numeric(9, 3)")
                    .HasColumnName("LACL");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lsl)
                    .HasColumnType("numeric(9, 3)")
                    .HasColumnName("LSL");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MonitorName).HasMaxLength(20);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.Uacl)
                    .HasColumnType("numeric(9, 3)")
                    .HasColumnName("UACL");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usl)
                    .HasColumnType("numeric(9, 3)")
                    .HasColumnName("USL");
            });

            modelBuilder.Entity<AutoAndonSpctran>(entity =>
            {
                entity.HasKey(e => e.TranId);

                entity.ToTable("AutoAndonSPCTrans");

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AndonCommt).HasMaxLength(255);

                entity.Property(e => e.AndonRegister)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.AndonTime).HasColumnType("datetime");

                entity.Property(e => e.CheckEndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckEndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckEndOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckEndTime).HasColumnType("datetime");

                entity.Property(e => e.CheckStartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckStartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckStartOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckStartTime).HasColumnType("datetime");

                entity.Property(e => e.CommentRank)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentPath).HasMaxLength(1024);

                entity.Property(e => e.GraphUrl)
                    .HasMaxLength(1024)
                    .HasColumnName("GraphURL");

                entity.Property(e => e.InspectionCode)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InspectionName).HasMaxLength(100);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ocapurl)
                    .HasMaxLength(1024)
                    .HasColumnName("OCAPURL");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Rule).HasMaxLength(255);

                entity.Property(e => e.RuleId).HasColumnName("RuleID");

                entity.Property(e => e.Spccondition).HasColumnName("SPCCondition");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AutoAndonTimeTran>(entity =>
            {
                entity.HasKey(e => e.TranId);

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.AbnormalCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualTime).HasColumnType("numeric(15, 5)");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AndonCommt).HasMaxLength(255);

                entity.Property(e => e.AndonRegister)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.AndonTime).HasColumnType("datetime");

                entity.Property(e => e.CheckEndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckEndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckEndOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckEndTime).HasColumnType("datetime");

                entity.Property(e => e.CheckStartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckStartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckStartOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckStartTime).HasColumnType("datetime");

                entity.Property(e => e.CommentRank)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControlType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DifferenceRate).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.DifferenceTime).HasColumnType("numeric(15, 5)");

                entity.Property(e => e.DocumentPath).HasMaxLength(1024);

                entity.Property(e => e.FromProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromProcessName).HasMaxLength(50);

                entity.Property(e => e.FromProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FromProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.FromResultTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStop)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TactTime).HasColumnType("numeric(15, 5)");

                entity.Property(e => e.Threshold).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.TimeCondition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToProcessName).HasMaxLength(50);

                entity.Property(e => e.ToProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ToProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.ToResultTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Boilicense>(entity =>
            {
                entity.HasKey(e => e.LicenseNo);

                entity.ToTable("BOILicense");

                entity.Property(e => e.LicenseNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LicenseName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.HasKey(e => new { e.CalendarDate, e.WeekMark });

                entity.ToTable("Calendar");

                entity.Property(e => e.CalendarDate).HasColumnType("date");

                entity.Property(e => e.WeekMark)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Capa>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CAPA");

                entity.Property(e => e.MachineNo).HasMaxLength(255);

                entity.Property(e => e.Rpm).HasColumnName("RPM");

                entity.Property(e => e.Type).HasMaxLength(255);
            });

            modelBuilder.Entity<Carrier>(entity =>
            {
                entity.HasKey(e => e.CarrierName);

                entity.ToTable("Carrier");

                entity.Property(e => e.CarrierName).HasMaxLength(50);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CarrierCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarrierCategory>(entity =>
            {
                entity.HasKey(e => e.CarrierCateg);

                entity.ToTable("CarrierCategory");

                entity.Property(e => e.CarrierCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CarrierCategName).HasMaxLength(50);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarrierMount>(entity =>
            {
                entity.HasKey(e => new { e.MachineNo, e.OpeGroupCode, e.CarrierNo, e.StartTime, e.SetCounter });

                entity.ToTable("CarrierMount");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CarrierNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SetCounter).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CarrierCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CarrierCategName).HasMaxLength(50);

                entity.Property(e => e.CarrierName).HasMaxLength(50);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.ToolCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolCategName).HasMaxLength(50);

                entity.Property(e => e.ToolLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarrierMountBefore20200801>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CarrierMount_before_20200801");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CarrierCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CarrierCategName).HasMaxLength(50);

                entity.Property(e => e.CarrierName).HasMaxLength(50);

                entity.Property(e => e.CarrierNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.ToolCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolCategName).HasMaxLength(50);

                entity.Property(e => e.ToolLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarrierMountWkTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CarrierMount_WK_Temp");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CarrierCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CarrierCategName).HasMaxLength(50);

                entity.Property(e => e.CarrierName).HasMaxLength(50);

                entity.Property(e => e.CarrierNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CarrierNo>(entity =>
            {
                entity.HasKey(e => e.CarrierNo1);

                entity.ToTable("CarrierNo");

                entity.Property(e => e.CarrierNo1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CarrierNo")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CarrierName).HasMaxLength(50);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CollateConbination>(entity =>
            {
                entity.HasKey(e => e.ConbinationName);

                entity.ToTable("CollateConbination");

                entity.Property(e => e.ConbinationName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CurrentLoadCarrierInfo>(entity =>
            {
                entity.HasKey(e => new { e.CarrierNo, e.OpeGroupCode, e.SetCounter });

                entity.ToTable("CurrentLoadCarrierInfo");

                entity.Property(e => e.CarrierNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SetCounter).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CarrierCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CarrierCategName).HasMaxLength(50);

                entity.Property(e => e.CarrierName).HasMaxLength(50);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CycleCountUpForLotEnd>(entity =>
            {
                entity.HasKey(e => new { e.OperationCode, e.MachineNo, e.Type, e.ProductCode });

                entity.ToTable("CycleCountUpForLotEnd");

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CycleTimeExclusion>(entity =>
            {
                entity.HasKey(e => new { e.CycleTimeExclusionId, e.OpeGroupCode });

                entity.ToTable("CycleTimeExclusion");

                entity.Property(e => e.CycleTimeExclusionId).HasColumnName("CycleTimeExclusionID");

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Defect>(entity =>
            {
                entity.HasKey(e => e.DefectCode);

                entity.ToTable("Defect");

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectName).HasMaxLength(30);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DefectAnalysis>(entity =>
            {
                entity.HasKey(e => e.ControlNo)
                    .HasName("PK_DefectAnalysis_1");

                entity.ToTable("DefectAnalysis");

                entity.Property(e => e.ControlNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AnalysisBaseProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AnalysisBaseProcessName)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.AnalysisEndTime).HasColumnType("datetime");

                entity.Property(e => e.AnalysisMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AnalysisOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AnalysisOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisStartTime).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectCode1)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode10)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode11)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode12)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode13)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode14)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode15)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode16)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode17)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode18)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode19)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode2)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode20)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode3)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode4)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode5)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode6)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode7)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode8)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode9)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectName1)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName10)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName11)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName12)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName13)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName14)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName15)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName16)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName17)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName18)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName19)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName2)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName20)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName3)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName4)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName5)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName6)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName7)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName8)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName9)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessStartTime).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Result)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DefectAnalysisLot>(entity =>
            {
                entity.HasKey(e => new { e.ControlNo, e.LotNo, e.LotNoSuffix })
                    .HasName("PK_DefectAnalysis");

                entity.ToTable("DefectAnalysisLot");

                entity.Property(e => e.ControlNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DefectGroup>(entity =>
            {
                entity.HasKey(e => e.DefectGroupCode);

                entity.ToTable("DefectGroup");

                entity.Property(e => e.DefectGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectGroupName).HasMaxLength(10);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DisplayDetail>(entity =>
            {
                entity.HasKey(e => new { e.OperatorId, e.SettingName, e.FormNo });

                entity.ToTable("DisplayDetail");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.SettingName).HasMaxLength(50);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DisplayDetailSearchInfo>(entity =>
            {
                entity.HasKey(e => new { e.OperatorId, e.SettingName, e.FormNo, e.ControlId, e.SearchInfoValue })
                    .HasName("PK_DisplayDetailSearchInfo_1");

                entity.ToTable("DisplayDetailSearchInfo");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.SettingName).HasMaxLength(50);

                entity.Property(e => e.ControlId)
                    .HasMaxLength(50)
                    .HasColumnName("ControlID");

                entity.Property(e => e.SearchInfoValue).HasMaxLength(50);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DisplayHeader>(entity =>
            {
                entity.HasKey(e => new { e.OperatorId, e.SettingName });

                entity.ToTable("DisplayHeader");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.SettingName).HasMaxLength(50);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pattern)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EqpmaintenanceControl>(entity =>
            {
                entity.HasKey(e => new { e.Eqpname, e.EqpobjectName });

                entity.ToTable("EQPMaintenanceControl");

                entity.Property(e => e.Eqpname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EQPName");

                entity.Property(e => e.EqpobjectName)
                    .HasMaxLength(50)
                    .HasColumnName("EQPObjectName");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NcimObjectName)
                    .HasMaxLength(50)
                    .HasColumnName("NCimObjectName");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ErrorLog>(entity =>
            {
                entity.HasKey(e => e.Date);

                entity.ToTable("ErrorLog");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage).HasMaxLength(4000);

                entity.Property(e => e.ErrorProcedure).HasMaxLength(128);
            });

            modelBuilder.Entity<ErrorLogBefore20200101>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ErrorLog_before_20200101");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ErrorMessage).HasMaxLength(4000);

                entity.Property(e => e.ErrorProcedure).HasMaxLength(128);
            });

            modelBuilder.Entity<ExcludeNcimChecking>(entity =>
            {
                entity.HasKey(e => new { e.ExcludeCheckItem, e.ProductCateg });

                entity.ToTable("ExcludeNCimChecking");

                entity.Property(e => e.ExcludeCheckItem)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FirstRegularOrderTran>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode, e.ProductCateg });

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InputDate).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Flow>(entity =>
            {
                entity.ToTable("Flow");

                entity.Property(e => e.FlowId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FlowID")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlowName).HasMaxLength(50);

                entity.Property(e => e.FlowType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GraphComment>(entity =>
            {
                entity.HasKey(e => e.ComId);

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComDay)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComHour)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComMonth)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComWeek)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComYear)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comments).HasMaxLength(512);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GraphName).HasMaxLength(50);

                entity.Property(e => e.GraphObjName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MonitoringGroup).HasMaxLength(20);

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.OperatorName).HasMaxLength(50);

                entity.Property(e => e.PeriodCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InputItem>(entity =>
            {
                entity.HasKey(e => e.ItemCode);

                entity.ToTable("InputItem");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Calculation)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataType).HasMaxLength(10);

                entity.Property(e => e.DefaultValue).HasMaxLength(50);

                entity.Property(e => e.InputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ValueCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<InputItemList>(entity =>
            {
                entity.HasKey(e => new { e.ItemCateg, e.ItemCode });

                entity.ToTable("InputItemList");

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InspectionReelHist>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.ReelNo });

                entity.ToTable("InspectionReelHist");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReelNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InvalidAndonHistory>(entity =>
            {
                entity.HasKey(e => e.SeqNo)
                    .IsClustered(false);

                entity.ToTable("InvalidAndonHistory");

                entity.Property(e => e.SeqNo).ValueGeneratedNever();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress")
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Memo).HasMaxLength(40);

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.PlaceOfUse).HasMaxLength(20);

                entity.Property(e => e.TerminalName).HasMaxLength(40);

                entity.Property(e => e.TerminalType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryCalendar>(entity =>
            {
                entity.HasKey(e => e.InventoryMonth);

                entity.ToTable("InventoryCalendar");

                entity.Property(e => e.InventoryMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.InventoryDate).HasColumnType("date");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItemCategory>(entity =>
            {
                entity.HasKey(e => e.ItemCateg);

                entity.ToTable("ItemCategory");

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InputKind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.Remarks1).HasMaxLength(50);

                entity.Property(e => e.Remarks2).HasMaxLength(50);

                entity.Property(e => e.Remarks3).HasMaxLength(50);

                entity.Property(e => e.Remarks4).HasMaxLength(50);

                entity.Property(e => e.Remarks5).HasMaxLength(50);

                entity.Property(e => e.RemarksColor1)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor2)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor3)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor4)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor5)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksTitle1).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle2).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle3).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle4).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle5).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasKey(e => new { e.GroupCode, e.Code });

                entity.ToTable("Language");

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value1).HasMaxLength(100);

                entity.Property(e => e.Value2).HasMaxLength(100);

                entity.Property(e => e.Value3).HasMaxLength(100);
            });

            modelBuilder.Entity<Licence>(entity =>
            {
                entity.HasKey(e => new { e.OperatorId, e.MachineNo });

                entity.ToTable("Licence");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LineGroup>(entity =>
            {
                entity.ToTable("LineGroup");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineGroupName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LineM>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("LineM");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.MaxWiplotCount)
                    .HasColumnType("numeric(12, 3)")
                    .HasColumnName("MaxWIPLotCount");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LineMachine>(entity =>
            {
                entity.HasKey(e => new { e.LineId, e.MachineNo });

                entity.ToTable("LineMachine");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LineMachineTemp>(entity =>
            {
                entity.HasKey(e => new { e.LineId, e.MachineNo });

                entity.ToTable("LineMachineTemp");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<LineType>(entity =>
            {
                entity.HasKey(e => new { e.LineId, e.Type });

                entity.ToTable("LineType");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotActualUnit>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessCode, e.MachineNo, e.EndTime, e.MaterialSpec });

                entity.ToTable("LotActualUnit");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.ActualUnitQty).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StandardUnitQty).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UsedQty).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotActualUnitTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LotActualUnit_Temp");

                entity.Property(e => e.ActualUnitQty).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StandardUnitQty).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UsedQty).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotAlarm>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.AlarmCategory, e.AlarmName });

                entity.ToTable("LotAlarm");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AlarmCategory).HasMaxLength(50);

                entity.Property(e => e.AlarmName).HasMaxLength(50);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotBlend>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.BlendLotNo, e.BlendLotNoSuffix, e.BlendCateg, e.BlendInOut });

                entity.ToTable("LotBlend");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlendLotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlendLotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlendCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlendInOut)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotBlendDetail>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.DetailSeqNo, e.BlendLotNo, e.BlendLotNoSuffix });

                entity.ToTable("LotBlendDetail");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlendLotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlendLotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.BlendCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlendInOut)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotComment>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.CommentNo });

                entity.ToTable("LotComment");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessSeqNo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Comment)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CommentCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CommentLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotCommentBefore20200101>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LotComment_before_20200101");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Comment)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CommentCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CommentLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.ProcessSeqNo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotCompleteHist>(entity =>
            {
                entity.HasKey(e => e.TransId);

                entity.ToTable("LotCompleteHist");

                entity.Property(e => e.TransId).HasColumnName("TransID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CompleteDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotDefect>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.DefectCode });

                entity.ToTable("LotDefect");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectName).HasMaxLength(30);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotDefectDetail>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.DetailSeqNo, e.DefectCode, e.BlendLotNo, e.BlendLotNoSuffix });

                entity.ToTable("LotDefectDetail");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlendLotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.BlendLotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectName).HasMaxLength(30);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotDefectTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LotDefect_Temp");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectName).HasMaxLength(20);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotInfo>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix });

                entity.ToTable("LotInfo");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AnswerOutputDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstimateOutputDate).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotInputControl>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo });

                entity.ToTable("LotInputControl");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fifocheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FIFOCheck")
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.Fifogroup)
                    .HasMaxLength(20)
                    .HasColumnName("FIFOGroup");

                entity.Property(e => e.LineOrMachine).HasMaxLength(20);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotInputControlTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LotInputControl_Temp");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fifocheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FIFOCheck")
                    .IsFixedLength();

                entity.Property(e => e.Fifogroup)
                    .HasMaxLength(20)
                    .HasColumnName("FIFOGroup");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineGroup).HasMaxLength(20);

                entity.Property(e => e.StartFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotMaterialDefect>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.MaterialLotNo, e.MaterialLotNoSuffix, e.DefectCode });

                entity.ToTable("LotMaterialDefect");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectName).HasMaxLength(30);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotMaterialProgress>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.MaterialLotNo, e.MaterialLotNoSuffix });

                entity.ToTable("LotMaterialProgress");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((11))")
                    .IsFixedLength();

                entity.Property(e => e.InputUnitName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'PCS')");

                entity.Property(e => e.MatDefectInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MatIninput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MatINInput")
                    .IsFixedLength();

                entity.Property(e => e.MatOutinput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MatOUTInput")
                    .IsFixedLength();

                entity.Property(e => e.MatSampleInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MatSurplusIninput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MatSurplusINInput")
                    .IsFixedLength();

                entity.Property(e => e.MatSurplusOutinput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MatSurplusOUTInput")
                    .IsFixedLength();

                entity.Property(e => e.MatUnclearInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.OutputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((11))")
                    .IsFixedLength();

                entity.Property(e => e.OutputUnitName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'PCS')");

                entity.Property(e => e.ShowMaterialInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateLotProgress)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotMaterialProgressTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LotMaterialProgress_Temp");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputUnitName).HasMaxLength(10);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MatDefectInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MatIninput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MatINInput")
                    .IsFixedLength();

                entity.Property(e => e.MatOutinput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MatOUTInput")
                    .IsFixedLength();

                entity.Property(e => e.MatSampleInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MatSurplusIninput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MatSurplusINInput")
                    .IsFixedLength();

                entity.Property(e => e.MatSurplusOutinput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MatSurplusOUTInput")
                    .IsFixedLength();

                entity.Property(e => e.MatUnclearInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.OutputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputUnitName).HasMaxLength(10);

                entity.Property(e => e.ShowMaterialInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateLotProgress)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotOperation>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.OperationCode, e.StartTime });

                entity.ToTable("LotOperation");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FinalResult)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotOperation20221024>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.OperationCode, e.StartTime });

                entity.ToTable("LotOperation_20221024");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FinalResult)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotOperationDetail>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.DetailSeqNo, e.OperationCode, e.StartTime });

                entity.ToTable("LotOperationDetail");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FinalResult)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotOperationHistory>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.OperationCode, e.StartTime });

                entity.ToTable("LotOperationHistory");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FinalResult)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotOperationItem>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.OperationCode, e.StartTime, e.ItemCateg, e.ItemCode });

                entity.ToTable("LotOperationItem");

                entity.HasIndex(e => e.StartTime, "idxsprDBInputCR_2");

                entity.HasIndex(e => new { e.Result, e.OperationCode }, "idxsprDbInputCR");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotOperationItem20221024>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.OperationCode, e.StartTime, e.ItemCateg, e.ItemCode });

                entity.ToTable("LotOperationItem_20221024");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotOperationItemDetail>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.DetailSeqNo, e.OperationCode, e.StartTime, e.ItemCateg, e.ItemCode });

                entity.ToTable("LotOperationItemDetail");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotOperationItemHistory>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.OperationCode, e.StartTime, e.ItemCateg, e.ItemCode });

                entity.ToTable("LotOperationItemHistory");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotOutput>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.OutputCode });

                entity.ToTable("LotOutput");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutputName).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotProgress>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo });

                entity.ToTable("LotProgress");

                entity.HasIndex(e => e.MachineNo, "idxsprDBInputOR");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContinuousStartFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.DefectCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.EndCarrierCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.EndCarrierSet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndPlanTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.InputLotCount).HasColumnType("numeric(4, 3)");

                entity.Property(e => e.InputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((11))")
                    .IsFixedLength();

                entity.Property(e => e.InputUnitName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'PCS')");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.MachineAlarmTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineEndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineGroup).HasMaxLength(20);

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineProductionTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStartTime).HasColumnType("datetime");

                entity.Property(e => e.MachineStopTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ncnno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NCNNo")
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputLotCount).HasColumnType("numeric(4, 3)");

                entity.Property(e => e.OutputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((11))")
                    .IsFixedLength();

                entity.Property(e => e.OutputUnitName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'PCS')");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductLabelPrint)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QtyCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.RegistType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.SplitLot)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierSet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartPlanTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SurplusSucceed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateCarrierEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength();

                entity.Property(e => e.UpdateMaterialEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.UpdateToolEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WipcontrolEnd).HasColumnName("WIPControlEnd");
            });

            modelBuilder.Entity<LotProgress20220906>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo })
                    .HasName("PK_LotProgress_20220906_W");

                entity.ToTable("LotProgress_20220906");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContinuousStartFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.DefectCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.EndCarrierCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.EndCarrierSet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndPlanTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.InputLotCount).HasColumnType("numeric(4, 3)");

                entity.Property(e => e.InputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((11))")
                    .IsFixedLength();

                entity.Property(e => e.InputUnitName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'PCS')");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.MachineAlarmTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineEndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineProductionTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStartTime).HasColumnType("datetime");

                entity.Property(e => e.MachineStopTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ncnno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NCNNo")
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputLotCount).HasColumnType("numeric(4, 3)");

                entity.Property(e => e.OutputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((11))")
                    .IsFixedLength();

                entity.Property(e => e.OutputUnitName)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'PCS')");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QtyCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.RegistType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.SplitLot)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierSet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartPlanTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SurplusSucceed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateCarrierEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength();

                entity.Property(e => e.UpdateMaterialEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.UpdateToolEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WipcontrolEnd).HasColumnName("WIPControlEnd");
            });

            modelBuilder.Entity<LotProgressDetail>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.DetailSeqNo });

                entity.ToTable("LotProgressDetail");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndCarrierNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndPlanTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.InputLotCount).HasColumnType("numeric(4, 3)");

                entity.Property(e => e.MachineAlarmTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineEndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineProductionTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStartTime).HasColumnType("datetime");

                entity.Property(e => e.MachineStopTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputLotCount).HasColumnType("numeric(4, 3)");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartPlanTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotProgressTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LotProgress_Temp");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContinuousStartFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndCarrierCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndCarrierSet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndPlanTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.InputLotCount).HasColumnType("numeric(4, 3)");

                entity.Property(e => e.InputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputUnitName).HasMaxLength(10);

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineAlarmTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineEndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineProductionTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStartTime).HasColumnType("datetime");

                entity.Property(e => e.MachineStopTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ncnno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NCNNo")
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputLotCount).HasColumnType("numeric(4, 3)");

                entity.Property(e => e.OutputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputUnitName).HasMaxLength(10);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QtyCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegistType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SplitLot)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierSet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartPlanTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SurplusSucceed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateCarrierEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateMaterialEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateToolEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WipcontrolEnd).HasColumnName("WIPControlEnd");
            });

            modelBuilder.Entity<LotSpecial>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo });

                entity.ToTable("LotSpecial");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotSplitHistory>(entity =>
            {
                entity.HasKey(e => new { e.SeqNo, e.IsParent, e.LotNo, e.LotNoSub });

                entity.ToTable("LotSplitHistory");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSub)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AbnormalMode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CustProdCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlowId)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("FlowID")
                    .IsFixedLength();

                entity.Property(e => e.Iecrv)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("IECRV")
                    .IsFixedLength();

                entity.Property(e => e.InputDate).HasColumnType("datetime");

                entity.Property(e => e.InputProcCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LotCompDate).HasColumnType("datetime");

                entity.Property(e => e.LotSplitProcess)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotStatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Operator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputDate).HasColumnType("datetime");

                entity.Property(e => e.OutputProcCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputUnit)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ParentLotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pono)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PONo")
                    .IsFixedLength();

                entity.Property(e => e.Posno)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("POSNo")
                    .IsFixedLength();

                entity.Property(e => e.Priority)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductModel)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReceivingCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RohmProdCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Spec)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tcr)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TCR")
                    .IsFixedLength();

                entity.Property(e => e.Tole)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TOLE")
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<LotTimeLimit>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.FromProcessSeqNo, e.FromProcessSe, e.ToProcessSeqNo, e.ToProcessSe, e.Sign });

                entity.ToTable("LotTimeLimit");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FromProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.ToProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ToProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AutoAndon)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromProcessName).HasMaxLength(50);

                entity.Property(e => e.FromResultTime).HasColumnType("datetime");

                entity.Property(e => e.ToLimitPlanTime).HasColumnType("datetime");

                entity.Property(e => e.ToProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToProcessName)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ToResultTime).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotTimeLimitTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LotTimeLimit_Temp");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromProcessName).HasMaxLength(50);

                entity.Property(e => e.FromProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FromProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.FromResultTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToLimitPlanTime).HasColumnType("datetime");

                entity.Property(e => e.ToProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToProcessName)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ToProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ToProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.ToResultTime).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotZtcinstruction>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.Ztccateg, e.Ztcno, e.ZtcnoSuffix, e.Ztcname });

                entity.ToTable("LotZTCInstruction");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ztccateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ZTCCateg")
                    .IsFixedLength();

                entity.Property(e => e.Ztcno)
                    .HasMaxLength(50)
                    .HasColumnName("ZTCNo");

                entity.Property(e => e.ZtcnoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ZTCNoSuffix");

                entity.Property(e => e.Ztcname)
                    .HasMaxLength(50)
                    .HasColumnName("ZTCName");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LotZtcinstructionWkTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LotZTCInstruction_WK_Temp");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ztccateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ZTCCateg")
                    .IsFixedLength();

                entity.Property(e => e.Ztcname)
                    .HasMaxLength(50)
                    .HasColumnName("ZTCName");

                entity.Property(e => e.Ztcno)
                    .HasMaxLength(50)
                    .HasColumnName("ZTCNo");

                entity.Property(e => e.ZtcnoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ZTCNoSuffix");
            });

            modelBuilder.Entity<LtprocessSnapShot>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo });

                entity.ToTable("LTProcessSnapShot");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LtsnapShot>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo });

                entity.ToTable("LTSnapShot");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Machine>(entity =>
            {
                entity.HasKey(e => e.MachineNo);

                entity.ToTable("Machine");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AlarmType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlendDefaultValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlendInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.ChangeProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangeProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.Eqpifcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("EQPIFCode")
                    .IsFixedLength();

                entity.Property(e => e.Ininput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INInput")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.LicenseNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineType).HasDefaultValueSql("((1))");

                entity.Property(e => e.Outcalculation)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("OUTCalculation");

                entity.Property(e => e.Outinput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OUTInput")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.ParentMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.SampleInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.SpecialInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.SpecialInputName).HasMaxLength(10);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SurplusIninput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SurplusINInput")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.SurplusOutcalculation)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SurplusOUTCalculation");

                entity.Property(e => e.SurplusOutinput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SurplusOUTInput")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.UnclearCalculation)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.UnclearInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineAlarmRpt>(entity =>
            {
                entity.HasKey(e => new { e.MachineNo, e.AlarmTime });

                entity.ToTable("MachineAlarmRpt");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AlarmTime).HasPrecision(3);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AlarmCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AlarmMessage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineGroup>(entity =>
            {
                entity.HasKey(e => new { e.MachineGroup1, e.MachineNo });

                entity.ToTable("MachineGroup");

                entity.Property(e => e.MachineGroup1)
                    .HasMaxLength(20)
                    .HasColumnName("MachineGroup");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineGroupProcess>(entity =>
            {
                entity.HasKey(e => new { e.ProcessCode, e.MachineGroup });

                entity.ToTable("MachineGroupProcess");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineGroup).HasMaxLength(20);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineMaintenance>(entity =>
            {
                entity.HasKey(e => new { e.MachineNo, e.OpeGroupCode, e.StartTime });

                entity.ToTable("MachineMaintenance");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MaintenanceReason).HasMaxLength(100);

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineMaintenanceBefore20200801>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MachineMaintenance_before_20200801");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaintenanceReason).HasMaxLength(100);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineOperation>(entity =>
            {
                entity.HasKey(e => new { e.MachineNo, e.OperationCode });

                entity.ToTable("MachineOperation");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineOperationLog>(entity =>
            {
                entity.HasKey(e => new { e.MachineNo, e.OperationCode });

                entity.ToTable("MachineOperationLog");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineProcess>(entity =>
            {
                entity.HasKey(e => new { e.MachineNo, e.ProcessCode });

                entity.ToTable("MachineProcess");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineProduct>(entity =>
            {
                entity.HasKey(e => new { e.MachineNo, e.Type, e.Lztcname });

                entity.ToTable("MachineProduct");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.Lztcname)
                    .HasMaxLength(50)
                    .HasColumnName("LZTCName");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lztccateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LZTCCateg")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineProductPlan>(entity =>
            {
                entity.HasKey(e => new { e.ProductDate, e.MachineNo });

                entity.ToTable("MachineProductPlan");

                entity.Property(e => e.ProductDate).HasColumnType("date");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductPlanQty).HasColumnType("numeric(11, 2)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineStatusRpt>(entity =>
            {
                entity.HasKey(e => new { e.MachineNo, e.StatusChangeTime });

                entity.ToTable("MachineStatusRpt");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusChangeTime).HasPrecision(3);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Machine_Temp");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AlarmType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlendDefaultValue)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlendInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangeProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangeProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eqpifcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("EQPIFCode")
                    .IsFixedLength();

                entity.Property(e => e.Ininput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INInput")
                    .IsFixedLength();

                entity.Property(e => e.LicenseNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Outcalculation)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("OUTCalculation");

                entity.Property(e => e.Outinput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OUTInput")
                    .IsFixedLength();

                entity.Property(e => e.ParentMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SampleInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialInputName).HasMaxLength(10);

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SurplusIninput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SurplusINInput")
                    .IsFixedLength();

                entity.Property(e => e.SurplusOutcalculation)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("SurplusOUTCalculation");

                entity.Property(e => e.SurplusOutinput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SurplusOUTInput")
                    .IsFixedLength();

                entity.Property(e => e.UnclearCalculation)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.UnclearInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MachineTemp201906>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Machine_Temp201906");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AlarmType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BlendInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangeProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangeProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Eqpifcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("EQPIFCode")
                    .IsFixedLength();

                entity.Property(e => e.Ininput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INInput")
                    .IsFixedLength();

                entity.Property(e => e.LicenseNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Outinput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OUTInput")
                    .IsFixedLength();

                entity.Property(e => e.ParentMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SampleInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SurplusIninput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SurplusINInput")
                    .IsFixedLength();

                entity.Property(e => e.SurplusOutinput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SurplusOUTInput")
                    .IsFixedLength();

                entity.Property(e => e.UnclearInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MailFormat>(entity =>
            {
                entity.HasKey(e => new { e.MailFormatCode, e.MailFormatSeq });

                entity.ToTable("MailFormat");

                entity.Property(e => e.MailFormatCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MailBody).HasMaxLength(256);

                entity.Property(e => e.MailTitle).HasMaxLength(100);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaintenanceSystemLog>(entity =>
            {
                entity.HasKey(e => e.LogId);

                entity.ToTable("MaintenanceSystemLog");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.Level)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Logger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LoggingDate).HasColumnType("datetime");

                entity.Property(e => e.LoginUserId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LoginUserID");

                entity.Property(e => e.LoginUserName).HasMaxLength(100);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Pcname)
                    .HasMaxLength(100)
                    .HasColumnName("PCName");

                entity.Property(e => e.Thread)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<MaintenanceSystemLogBefore20200101>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MaintenanceSystemLog_before_20200101");

                entity.Property(e => e.Level)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LogId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("LogID");

                entity.Property(e => e.Logger)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LoggingDate).HasColumnType("datetime");

                entity.Property(e => e.LoginUserId)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("LoginUserID");

                entity.Property(e => e.LoginUserName).HasMaxLength(100);

                entity.Property(e => e.Message).HasMaxLength(4000);

                entity.Property(e => e.Pcname)
                    .HasMaxLength(100)
                    .HasColumnName("PCName");

                entity.Property(e => e.Thread)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<MaterialMachine>(entity =>
            {
                entity.HasKey(e => new { e.MachineNo, e.MaterialCateg });

                entity.ToTable("MaterialMachine");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MatDefectInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.MatIninput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MatINInput")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.MatOutinput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MatOUTInput")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.MatSampleInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.MatSurplusIninput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MatSurplusINInput")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.MatSurplusOutinput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MatSurplusOUTInput")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.MatUnclearInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialMount>(entity =>
            {
                entity.HasKey(e => new { e.MachineNo, e.OpeGroupCode, e.MaterialLotNo, e.MaterialLotNoSuffix, e.StartTime });

                entity.ToTable("MaterialMount");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CheckOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.QtyUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QtyUnitName).HasMaxLength(10);

                entity.Property(e => e.RemainQty).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.SetQty).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UseQty).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialMountBefore20200801>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MaterialMount_before_20200801");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QtyUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QtyUnitName).HasMaxLength(10);

                entity.Property(e => e.RemainQty).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.SetQty).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UseQty).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialMountTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MaterialMount_Temp");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialMountTemp201906>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MaterialMount_Temp201906");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialMountVerupTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MaterialMount_verupTemp");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QtyUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QtyUnitName).HasMaxLength(10);

                entity.Property(e => e.RemainQty).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.SetQty).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UseQty).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialProcessFlow>(entity =>
            {
                entity.HasKey(e => new { e.FlowId, e.ProcessSeqNo, e.MaterialCateg });

                entity.ToTable("MaterialProcessFlow");

                entity.Property(e => e.FlowId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FlowID")
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShowMaterialInput)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateLotProgress)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialSpecification>(entity =>
            {
                entity.HasKey(e => new { e.MaterialSpec, e.MakerCode, e.SpecificationsNo });

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.MakerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(1024);

                entity.Property(e => e.SpecificationsPath).HasMaxLength(1024);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MmaterialLot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("MMaterial_Lot");

                entity.Property(e => e.AvailableEndTime).HasColumnType("datetime");

                entity.Property(e => e.AvailableStartTime).HasColumnType("datetime");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.MakerCode).HasMaxLength(50);

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCategoryName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo).HasMaxLength(50);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.MaterialSpec).HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnType("numeric(13, 3)");

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.UnitCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Warehouse)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MmaterialLotBak20161114>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_MMaterial_Lot_bak20161114");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.MakerCode)
                    .HasMaxLength(50)
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.MaterialCategoryName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.MaterialName).HasMaxLength(74);

                entity.Property(e => e.Qty).HasColumnType("numeric(13, 3)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .UseCollation("Japanese_CI_AS");

                entity.Property(e => e.Warehouse)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .UseCollation("Japanese_CI_AS");
            });

            modelBuilder.Entity<MmaterialLotBak20170131>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_MMaterial_Lot_bak20170131");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.MakerCode).HasMaxLength(50);

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCategoryName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNo).HasMaxLength(50);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(74);

                entity.Property(e => e.Qty).HasColumnType("numeric(13, 3)");

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.Warehouse)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MmaterialLotBak20710530>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_MMaterial_Lot_bak20710530");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.MakerCode).HasMaxLength(50);

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCategoryName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNo).HasMaxLength(50);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(74);

                entity.Property(e => e.Qty).HasColumnType("numeric(13, 3)");

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.Warehouse)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MonitoringTarget>(entity =>
            {
                entity.HasKey(e => new { e.FromDate, e.MonitoringGroup, e.ProcessCode, e.TargetKind, e.TargetType });

                entity.ToTable("MonitoringTarget");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.MonitoringGroup).HasMaxLength(20);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TargetKind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TargetType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TargetValue).HasColumnType("numeric(11, 2)");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NcimMenuItem>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.MenuCode });

                entity.ToTable("NCimMenuItem");

                entity.Property(e => e.MenuId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MenuID")
                    .IsFixedLength();

                entity.Property(e => e.MenuCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuColor)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MenuTitle).HasMaxLength(20);

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParentMenuCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.Url)
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NcimOutputControl>(entity =>
            {
                entity.HasKey(e => new { e.AndonType, e.ControlType, e.OccuredTerminal });

                entity.ToTable("NCimOutputControl");

                entity.Property(e => e.AndonType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ControlType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OccuredTerminal)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AddressGroup)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Address_Group")
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutputGroupCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NcimRemoteControl>(entity =>
            {
                entity.HasKey(e => new { e.Eqpifcode, e.RequestCategory, e.WipFlag, e.ProcessingResult });

                entity.ToTable("NCimRemoteControl");

                entity.Property(e => e.Eqpifcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("EQPIFCode")
                    .IsFixedLength();

                entity.Property(e => e.RequestCategory)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WipFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessingResult)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WipsendFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("WIPSendFlag")
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NcimTerminalControl>(entity =>
            {
                entity.HasKey(e => e.Ipaddress);

                entity.ToTable("NCimTerminalControl");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memo).HasMaxLength(40);

                entity.Property(e => e.PlaceOfUse).HasMaxLength(20);

                entity.Property(e => e.TerminalName).HasMaxLength(40);

                entity.Property(e => e.TerminalType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NcimTerminalMenu>(entity =>
            {
                entity.HasKey(e => new { e.Ipaddress, e.ApplicationName, e.MachineNo });

                entity.ToTable("NCimTerminalMenu");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress")
                    .IsFixedLength();

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNoInputFlag)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("MenuID")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NcimToEqpif>(entity =>
            {
                entity.HasKey(e => e.Eqpifcode);

                entity.ToTable("NCimToEQPIF");

                entity.Property(e => e.Eqpifcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("EQPIFCode")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CarrierSetTrans).HasMaxLength(50);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialSetTrans).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.RemoteControl).HasMaxLength(50);

                entity.Property(e => e.ServerResponse).HasMaxLength(50);

                entity.Property(e => e.ToolSetTrans).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkInProcess).HasMaxLength(50);
            });

            modelBuilder.Entity<Operation>(entity =>
            {
                entity.HasKey(e => e.OperationCode);

                entity.ToTable("Operation");

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.BarcodeQrformat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BarcodeQRFormat")
                    .IsFixedLength();

                entity.Property(e => e.ChangeDisableStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangeMachineStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Equipment)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength();

                entity.Property(e => e.InputItemControl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputKind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputQtyUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputRemainQty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputSetQty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputUseQty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoInputFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeScope)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartEndFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationCycleCtrl>(entity =>
            {
                entity.HasKey(e => new { e.OperationCode, e.MachineNo });

                entity.ToTable("OperationCycleCtrl");

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CheckCateg1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckCateg2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckCateg3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckOpeCode1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckOpeCode2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckOpeCode3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountClearOpeCode1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountClearOpeCode2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountClearOpeCode3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountUpOpeCode1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountUpOpeCode2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountUpOpeCode3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CycleTimeExclusionId).HasColumnName("CycleTimeExclusionID");

                entity.Property(e => e.CycleTimeMode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationCycleCtrl20200707>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OperationCycleCtrl_20200707");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CheckCateg1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckCateg2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckCateg3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckOpeCode1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckOpeCode2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckOpeCode3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountClearOpeCode1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountClearOpeCode2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountClearOpeCode3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountUpOpeCode1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountUpOpeCode2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountUpOpeCode3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationCycleCtrlBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OperationCycleCtrl_bk");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CheckCateg1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckCateg2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckCateg3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckOpeCode1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckOpeCode2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckOpeCode3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountClearOpeCode1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountClearOpeCode2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountClearOpeCode3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountUpOpeCode1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountUpOpeCode2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountUpOpeCode3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CycleTimeExclusionId).HasColumnName("CycleTimeExclusionID");

                entity.Property(e => e.CycleTimeMode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationCycleTran>(entity =>
            {
                entity.HasKey(e => new { e.OperationCode, e.MachineNo });

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperationTime).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationGroup>(entity =>
            {
                entity.HasKey(e => e.OpeGroupCode);

                entity.ToTable("OperationGroup");

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualWorkingGraph)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.SpecialOperate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.SpecialOperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationGroupTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OperationGroup_Temp");

                entity.Property(e => e.ActualWorkingColor)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ActualWorkingGraph)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationItemCateg>(entity =>
            {
                entity.HasKey(e => new { e.OperationCode, e.ProcessCode, e.Type, e.ProductCode, e.ItemCateg });

                entity.ToTable("OperationItemCateg");

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationTact>(entity =>
            {
                entity.HasKey(e => new { e.OpeGroupCode, e.MachineNo });

                entity.ToTable("OperationTact");

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationTran>(entity =>
            {
                entity.HasKey(e => e.TranId);

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo).HasMaxLength(50);

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationTime).HasColumnType("datetime");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationTrans20161215>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OperationTrans_20161215");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo).HasMaxLength(50);

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationTime).HasColumnType("datetime");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.TranId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TranID");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationTransBefore20200101>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OperationTrans_before_20200101");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo).HasMaxLength(50);

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationTime).HasColumnType("datetime");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.TranId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("TranID");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationWebApi>(entity =>
            {
                entity.HasKey(e => new { e.OperationCode, e.ProcessCode, e.MachineNo, e.Type, e.ProductCode, e.ExecutionOrder });

                entity.ToTable("OperationWebAPI");

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Httpmethod)
                    .HasMaxLength(10)
                    .HasColumnName("HTTPMethod")
                    .IsFixedLength();

                entity.Property(e => e.ParameterCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WebApi)
                    .HasMaxLength(100)
                    .HasColumnName("WebAPI");
            });

            modelBuilder.Entity<Operator>(entity =>
            {
                entity.ToTable("Operator");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Authority)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorName).HasMaxLength(50);

                entity.Property(e => e.Password)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperatorRole>(entity =>
            {
                entity.HasKey(e => new { e.OperatorId, e.RoleId });

                entity.ToTable("OperatorRole");

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.RoleId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("RoleID")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Output>(entity =>
            {
                entity.HasKey(e => e.OutputCode);

                entity.ToTable("Output");

                entity.Property(e => e.OutputCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutputName).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OutputGroup>(entity =>
            {
                entity.HasKey(e => new { e.OutputGroupCode, e.Ipaddress });

                entity.ToTable("OutputGroup");

                entity.Property(e => e.OutputGroupCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutputGroupName).HasMaxLength(40);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Priority>(entity =>
            {
                entity.HasKey(e => e.PriorityNo);

                entity.ToTable("Priority");

                entity.Property(e => e.PriorityNo)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PriorityName).HasMaxLength(50);
            });

            modelBuilder.Entity<Process>(entity =>
            {
                entity.HasKey(e => e.ProcessCode);

                entity.ToTable("Process");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mlc21process)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MLC21Process")
                    .IsFixedLength();

                entity.Property(e => e.Mow21processNo)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("MOW21ProcessNo")
                    .IsFixedLength();

                entity.Property(e => e.OutputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessKind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProcessRangeCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessRangeName).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProcessArrange>(entity =>
            {
                entity.HasKey(e => new { e.ProcessCode, e.MachineNo, e.ArrangeOpeCode, e.OpeGroupCode });

                entity.ToTable("ProcessArrange");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ArrangeOpeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisplayOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.InputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1')")
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProcessCalendar>(entity =>
            {
                entity.HasKey(e => new { e.InventoryMonth, e.ProcessCode });

                entity.ToTable("ProcessCalendar");

                entity.Property(e => e.InventoryMonth)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProcessDefect>(entity =>
            {
                entity.HasKey(e => new { e.ProcessCode, e.DefectCode });

                entity.ToTable("ProcessDefect");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProcessDefectRelation>(entity =>
            {
                entity.HasKey(e => new { e.ScrapProcessCode, e.ScrapDefectCode, e.UnScrapProcessCode, e.UnScrapDefectCode });

                entity.ToTable("ProcessDefectRelation");

                entity.Property(e => e.ScrapProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ScrapDefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnScrapProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnScrapDefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProcessFlow>(entity =>
            {
                entity.HasKey(e => new { e.FlowId, e.ProcessSeqNo });

                entity.ToTable("ProcessFlow");

                entity.Property(e => e.FlowId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FlowID")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContinuousStartFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.DefectCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.EndCarrierCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.EndCarrierSet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductLabelPrint)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QtyCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.SplitLot)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierSet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.SurplusSucceed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateCarrierEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength();

                entity.Property(e => e.UpdateMaterialEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.UpdateToolEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WipcontrolEnd).HasColumnName("WIPControlEnd");
            });

            modelBuilder.Entity<ProcessGroup>(entity =>
            {
                entity.HasKey(e => new { e.ProcessGroup1, e.ProcessCode });

                entity.ToTable("ProcessGroup");

                entity.Property(e => e.ProcessGroup1)
                    .HasMaxLength(50)
                    .HasColumnName("ProcessGroup");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProcessOutput>(entity =>
            {
                entity.HasKey(e => new { e.ProcessCode, e.Type, e.ProductCode, e.OutputCode });

                entity.ToTable("ProcessOutput");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProcessStartEndControl>(entity =>
            {
                entity.HasKey(e => new { e.FlowId, e.ProductCode, e.ProcessSeqNo, e.StartEndFlag });

                entity.ToTable("ProcessStartEndControl");

                entity.Property(e => e.FlowId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FlowID")
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartEndFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductCarrier>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode, e.ProcessCode, e.MachineNo, e.MachineCateg, e.OpeGroupCode, e.CarrierName });

                entity.ToTable("ProductCarrier");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CarrierName).HasMaxLength(50);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductComment>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode, e.FlowId, e.ProcessSeqNo, e.CommentNo });

                entity.ToTable("ProductComment");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlowId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FlowID")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.Comment)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.CommentCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CommentLevel)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductDetailPlan>(entity =>
            {
                entity.HasKey(e => new { e.FromDate, e.MonitoringGroup, e.ProductCode, e.ProcessCode, e.LineId, e.PlanTime });

                entity.ToTable("ProductDetailPlan");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.MonitoringGroup).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutPlanQtyPerHour).HasColumnType("numeric(11, 2)");

                entity.Property(e => e.ToDate).HasColumnType("date");

                entity.Property(e => e.Unit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductFlow>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode, e.ProductCateg });

                entity.ToTable("ProductFlow");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlowId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FlowID")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductGroup>(entity =>
            {
                entity.HasKey(e => new { e.ProductGroup1, e.Type, e.ProductCode });

                entity.ToTable("ProductGroup");

                entity.Property(e => e.ProductGroup1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ProductGroup")
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductMachine>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.Lztcname, e.ProcessCode, e.MachineNo });

                entity.ToTable("ProductMachine");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.Lztcname)
                    .HasMaxLength(50)
                    .HasColumnName("LZTCName");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lztccateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("LZTCCateg")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductMaterial>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode, e.ProcessCode, e.ProductCateg, e.MachineNo, e.MachineCateg, e.SlotNo, e.MaterialSpec });

                entity.ToTable("ProductMaterial");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')")
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(host_name())");

                entity.Property(e => e.ConbinationName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnneedMaterialCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(suser_sname())");
            });

            modelBuilder.Entity<ProductMaterialDf20221111>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductMaterial_df20221111");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConbinationName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UnneedMaterialCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductMaterialTemp>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode, e.ProcessCode, e.MachineNo, e.MachineCateg, e.SlotNo, e.MaterialSpec })
                    .HasName("PK_ProductMaterial_umt6h");

                entity.ToTable("ProductMaterial_Temp");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.ConbinationName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnneedMaterialCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProductPlan>(entity =>
            {
                entity.HasKey(e => new { e.ProductDate, e.MonitoringGroup, e.ProductCode, e.ProcessCode, e.LineId, e.TimeZoneCode });

                entity.ToTable("ProductPlan");

                entity.Property(e => e.ProductDate).HasColumnType("date");

                entity.Property(e => e.MonitoringGroup).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.TimeZoneCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryPlanQty).HasColumnType("numeric(11, 2)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductPlanBefore20200101>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductPlan_before_20200101");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryPlanQty).HasColumnType("numeric(11, 2)");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.MonitoringGroup).HasMaxLength(20);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductDate).HasColumnType("date");

                entity.Property(e => e.TimeZoneCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductTool>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode, e.ProcessCode, e.MachineNo, e.MachineCateg, e.SlotNo, e.ToolName });

                entity.ToTable("ProductTool");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConbinationName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnneedToolCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductToolBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductTool_bk");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConbinationName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UnneedToolCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductToolDf20221111>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductTool_df20221111");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConbinationName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UnneedToolCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductToolDf202211111>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ProductTool_df20221111_");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConbinationName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MachineCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UnneedToolCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductToolTemp>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode, e.ProcessCode, e.MachineNo, e.MachineCateg, e.SlotNo, e.ToolName });

                entity.ToTable("ProductTool_Temp");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.ConbinationName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnneedToolCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProductUnContinuou>(entity =>
            {
                entity.HasKey(e => new { e.ProcessCode, e.Type1, e.ProductCode1, e.Type2, e.ProductCode2 });

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type1).HasMaxLength(20);

                entity.Property(e => e.ProductCode1)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type2).HasMaxLength(20);

                entity.Property(e => e.ProductCode2)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CommentCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductUnContinuousGroup>(entity =>
            {
                entity.HasKey(e => new { e.ProductGroup, e.Type, e.ProductCode });

                entity.ToTable("ProductUnContinuousGroup");

                entity.Property(e => e.ProductGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductlUnContinuou>(entity =>
            {
                entity.HasKey(e => new { e.ProcessCode, e.GroupNo, e.Type, e.ProductCode })
                    .HasName("PK_MaterialContinuous_1");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CommentCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')")
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Profilelog>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__PROFILEL__AAAC09D8A1D2075F");

                entity.ToTable("PROFILELOG", "db_owner");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasMaxLength(128)
                    .HasColumnName("NTUserName");

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<Profilelog1>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__PROFILEL__AAAC09D82BAC7765");

                entity.ToTable("PROFILELOG");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasMaxLength(128)
                    .HasColumnName("NTUserName");

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("RoleID")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoleObject>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.DisabledObject })
                    .HasName("PK_RoleObject_1");

                entity.ToTable("RoleObject");

                entity.Property(e => e.RoleId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("RoleID")
                    .IsFixedLength();

                entity.Property(e => e.DisabledObject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RpmImport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RPM_IMPORT");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RohmPackage).HasMaxLength(20);

                entity.Property(e => e.Rpm).HasColumnName("RPM");
            });

            modelBuilder.Entity<SerialMaster>(entity =>
            {
                entity.HasKey(e => new { e.SerialNo, e.LotNo, e.LotNoSuffix });

                entity.ToTable("SerialMaster");

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputUnitName).HasMaxLength(10);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SubUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SubUnitName).HasMaxLength(10);

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SerialTimeLimit>(entity =>
            {
                entity.HasKey(e => new { e.SerialNo, e.LotNo, e.LotNoSuffix, e.FromProcessSeqNo, e.FromProcessSe, e.ToProcessSeqNo, e.ToProcessSe, e.Sign });

                entity.ToTable("SerialTimeLimit");

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FromProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.ToProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ToProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AutoAndon)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromProcessName).HasMaxLength(50);

                entity.Property(e => e.FromResultTime).HasColumnType("datetime");

                entity.Property(e => e.ToLimitPlanTime).HasColumnType("datetime");

                entity.Property(e => e.ToProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToProcessName).HasMaxLength(50);

                entity.Property(e => e.ToResultTime).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShiftCalendar>(entity =>
            {
                entity.HasKey(e => new { e.ShiftDay, e.TimeZoneCode });

                entity.ToTable("ShiftCalendar");

                entity.Property(e => e.ShiftDay).HasColumnType("date");

                entity.Property(e => e.TimeZoneCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftName).HasMaxLength(30);

                entity.Property(e => e.ShiftType).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmallProcLotDefect>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.SmallProcessSeqNo, e.DefectCode });

                entity.ToTable("SmallProcLotDefect");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectName).HasMaxLength(30);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmallProcProgress>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo, e.SmallProcessSeqNo });

                entity.ToTable("SmallProcProgress");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndPlanTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputName1).HasMaxLength(50);

                entity.Property(e => e.OutputName2).HasMaxLength(50);

                entity.Property(e => e.SmallProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmallProcessName).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartPlanTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SmallProcessFlow>(entity =>
            {
                entity.HasKey(e => new { e.FlowId, e.ProcessSeqNo, e.SmallProcessSeqNo });

                entity.ToTable("SmallProcessFlow");

                entity.Property(e => e.FlowId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FlowID")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SmallProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StandardUnit>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode, e.ProductCategory, e.ProductVer, e.ProcessCode, e.MaterialSpec, e.MaterialVer });

                entity.ToTable("StandardUnit");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCategory)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveEndDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveStartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FromWarehouse)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.KittingOn)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LogisticsUnitCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MainSubCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialInputQty).HasColumnType("numeric(9, 3)");

                entity.Property(e => e.Orcombination)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORCombination")
                    .IsFixedLength();

                entity.Property(e => e.ProcessingUnitCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StandardUnitQty).HasColumnType("numeric(18, 9)");

                entity.Property(e => e.ToWarehouse)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.StatusCode);

                entity.ToTable("Status");

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mlc21statusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MLC21StatusCode")
                    .IsFixedLength();

                entity.Property(e => e.StatusName).HasMaxLength(50);

                entity.Property(e => e.StopFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SupplementItem>(entity =>
            {
                entity.HasKey(e => e.SupplementId);

                entity.ToTable("SupplementItem");

                entity.HasIndex(e => new { e.SupplementCateg, e.MachineNo, e.OpeGroupCode, e.Ztcno, e.ZtcnoSuffix, e.KeyTime, e.OperationCode, e.StartTime }, "IX_SupplementItem")
                    .IsUnique();

                entity.Property(e => e.SupplementId).HasColumnName("SupplementID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FinalResult)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.KeyTime).HasColumnType("datetime");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SupplementCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ztcno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ZTCNo");

                entity.Property(e => e.ZtcnoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ZTCNoSuffix");
            });

            modelBuilder.Entity<SupplementItemBefore20200101>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SupplementItem_before_20200101");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FinalResult)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.KeyTime).HasColumnType("datetime");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SupplementCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplementId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SupplementID");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ztcno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ZTCNo");

                entity.Property(e => e.ZtcnoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ZTCNoSuffix");
            });

            modelBuilder.Entity<SupplementItemCateg>(entity =>
            {
                entity.HasKey(e => new { e.OperationCode, e.MachineNo, e.Ztcname, e.ItemCateg });

                entity.ToTable("SupplementItemCateg");

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ztcname)
                    .HasMaxLength(50)
                    .HasColumnName("ZTCName");

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SupplementItemDetail>(entity =>
            {
                entity.HasKey(e => e.SupplementId);

                entity.ToTable("SupplementItemDetail");

                entity.HasIndex(e => new { e.SupplementCateg, e.MachineNo, e.OpeGroupCode, e.Ztcno, e.ZtcnoSuffix, e.KeyTime, e.OperationCode, e.StartTime, e.ItemCateg, e.ItemCode }, "IX_SupplementItemDetail")
                    .IsUnique();

                entity.Property(e => e.SupplementId).HasColumnName("SupplementID");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.KeyTime).HasColumnType("datetime");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SupplementCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ztcno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ZTCNo");

                entity.Property(e => e.ZtcnoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ZTCNoSuffix");
            });

            modelBuilder.Entity<SupplementItemDetail20200101>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SupplementItemDetail_20200101");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.KeyTime).HasColumnType("datetime");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SupplementCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SupplementId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SupplementID");

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ztcno)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ZTCNo");

                entity.Property(e => e.ZtcnoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ZTCNoSuffix");
            });

            modelBuilder.Entity<SynonymCarrierMap>(entity =>
            {
                entity.HasKey(e => new { e.CarrierNo, e.Address1, e.Address2 });

                entity.ToTable("SynonymCarrierMap");

                entity.Property(e => e.CarrierNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address1)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Address2)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotSfxNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MappingTime).HasColumnType("datetime");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysVerControl>(entity =>
            {
                entity.HasKey(e => new { e.SysName, e.DeviceGroup, e.DeviceName });

                entity.ToTable("SysVerControl");

                entity.Property(e => e.SysName).HasMaxLength(30);

                entity.Property(e => e.DeviceGroup)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentVersion)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReleaseVersion)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VerUpDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SystemSetting>(entity =>
            {
                entity.HasKey(e => new { e.GroupCode, e.Code });

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value1).HasMaxLength(100);

                entity.Property(e => e.Value2).HasMaxLength(100);
            });

            modelBuilder.Entity<TWorkLt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("T_WorkLT");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<Tact>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode, e.ProcessCode, e.MachineNo });

                entity.ToTable("Tact");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')")
                    .IsFixedLength();

                entity.Property(e => e.Abnormal)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TactBaseUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TactTime).HasColumnType("numeric(9, 5)");

                entity.Property(e => e.Threshold).HasColumnType("numeric(12, 3)");

                entity.Property(e => e.TimeCondition)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBq>(entity =>
            {
                entity.HasKey(e => new { e.Bqcode, e.OpeCode });

                entity.ToTable("tbl_BQ");

                entity.Property(e => e.Bqcode)
                    .HasMaxLength(10)
                    .HasColumnName("BQCode");

                entity.Property(e => e.OpeCode).HasMaxLength(10);

                entity.Property(e => e.Bqname)
                    .HasMaxLength(10)
                    .HasColumnName("BQName");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBqclass>(entity =>
            {
                entity.HasKey(e => e.OperatorCode);

                entity.ToTable("tbl_BQClass");

                entity.Property(e => e.OperatorCode)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Class)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClassDv)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ClassDV");

                entity.Property(e => e.OperatorName).HasMaxLength(40);

                entity.Property(e => e.Tips).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBqclassDaoDv>(entity =>
            {
                entity.HasKey(e => new { e.ClassDv, e.CurrentDay, e.StartTime });

                entity.ToTable("tbl_BQClassDaoDV");

                entity.Property(e => e.ClassDv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ClassDV")
                    .IsFixedLength();

                entity.Property(e => e.CurrentDay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Time).HasColumnType("numeric(18, 1)");
            });

            modelBuilder.Entity<TblBqitem>(entity =>
            {
                entity.HasKey(e => e.Bqcode);

                entity.ToTable("tbl_BQItem");

                entity.Property(e => e.Bqcode)
                    .HasMaxLength(10)
                    .HasColumnName("BQCode");

                entity.Property(e => e.Bqname)
                    .HasMaxLength(40)
                    .HasColumnName("BQName");

                entity.Property(e => e.BqnewName)
                    .HasMaxLength(40)
                    .HasColumnName("BQNewName");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblBqtable>(entity =>
            {
                entity.HasKey(e => e.SeqNo)
                    .HasName("PK_tbl_BQTable_1");

                entity.ToTable("tbl_BQTable");

                entity.Property(e => e.Bqcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BQCode");

                entity.Property(e => e.Bqname)
                    .HasMaxLength(40)
                    .HasColumnName("BQName");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineNo).HasMaxLength(100);

                entity.Property(e => e.OpName).HasMaxLength(40);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Time).HasColumnType("numeric(18, 1)");
            });

            modelBuilder.Entity<TblBqtableMonth>(entity =>
            {
                entity.HasKey(e => e.SeqNo);

                entity.ToTable("tbl_BQTableMonth");

                entity.Property(e => e.Bqcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BQCode");

                entity.Property(e => e.Bqname)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BQName");

                entity.Property(e => e.ClassDv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ClassDV");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineNo).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Time).HasColumnType("numeric(18, 1)");
            });

            modelBuilder.Entity<TblBqtableMonthNoInput>(entity =>
            {
                entity.HasKey(e => e.SeqNo);

                entity.ToTable("tbl_BQTableMonthNoInput");

                entity.Property(e => e.Bqcode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("BQCode");

                entity.Property(e => e.Bqname)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("BQName");

                entity.Property(e => e.ClassDv)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ClassDV");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineNo).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Time).HasColumnType("numeric(18, 1)");
            });

            modelBuilder.Entity<TblBqtempDailyDetail>(entity =>
            {
                entity.HasKey(e => new { e.Opid, e.Catege, e.StartTime, e.EndTime });

                entity.ToTable("tbl_BQTempDailyDetail");

                entity.Property(e => e.Opid)
                    .HasMaxLength(50)
                    .HasColumnName("OPID");

                entity.Property(e => e.Catege).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.BqCode).HasMaxLength(20);

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo).HasMaxLength(50);

                entity.Property(e => e.MaintenanceReason).HasMaxLength(100);

                entity.Property(e => e.NeedTime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.Per).HasMaxLength(50);
            });

            modelBuilder.Entity<TblBqtempMonthDetail>(entity =>
            {
                entity.HasKey(e => new { e.Date8, e.Opid, e.BqCode, e.MachineNo, e.MachineName, e.OpeGroupName, e.StartTime, e.EndTime });

                entity.ToTable("tbl_BQTempMonthDetail");

                entity.Property(e => e.Date8).HasMaxLength(10);

                entity.Property(e => e.Opid)
                    .HasMaxLength(50)
                    .HasColumnName("OPID");

                entity.Property(e => e.BqCode).HasMaxLength(20);

                entity.Property(e => e.MachineNo).HasMaxLength(50);

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Catege).HasMaxLength(50);

                entity.Property(e => e.Class).HasMaxLength(10);

                entity.Property(e => e.MaintenanceReason).HasMaxLength(100);

                entity.Property(e => e.NeedTime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Per).HasMaxLength(50);
            });

            modelBuilder.Entity<TblBqunLockTran>(entity =>
            {
                entity.HasKey(e => e.UnLockId);

                entity.ToTable("tbl_BQUnLockTrans");

                entity.Property(e => e.UnLockId).HasColumnName("unLockID");

                entity.Property(e => e.AlarmTime).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasMaxLength(50);

                entity.Property(e => e.LockOperator)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasMaxLength(50);

                entity.Property(e => e.UnLockOperator)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnLockRemarks).HasMaxLength(1000);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMachineRunList>(entity =>
            {
                entity.HasKey(e => new { e.LineId, e.Process, e.MachineNo });

                entity.ToTable("tbl_MachineRunList");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.Process).HasMaxLength(60);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Testinsert>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("testinsert");

                entity.Property(e => e.ActQty1).HasColumnType("decimal(13, 2)");

                entity.Property(e => e.Category)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Category2)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Date1)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Date2)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FactoryName)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Level1)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Level2)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperatingCategory)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PackageName).HasMaxLength(20);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProdCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RohmPn)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RohmPN")
                    .IsFixedLength();

                entity.Property(e => e.Time1)
                    .HasMaxLength(64)
                    .IsUnicode(false);

                entity.Property(e => e.Time2)
                    .HasMaxLength(64)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimeLimitControl>(entity =>
            {
                entity.HasKey(e => new { e.FlowId, e.FromProcessSeqNo, e.FromProcessSe, e.ToProcessSeqNo, e.ToProcessSe, e.Sign });

                entity.ToTable("TimeLimitControl");

                entity.Property(e => e.FlowId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FlowID")
                    .IsFixedLength();

                entity.Property(e => e.FromProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FromProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.ToProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ToProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AutoAndon)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimeZone>(entity =>
            {
                entity.HasKey(e => e.TimeZoneCode);

                entity.ToTable("TimeZone");

                entity.Property(e => e.TimeZoneCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TimeZoneCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TimeZoneName).HasMaxLength(30);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Tool>(entity =>
            {
                entity.HasKey(e => e.ToolName);

                entity.ToTable("Tool");

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.ToolCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToolCategory>(entity =>
            {
                entity.HasKey(e => e.ToolCateg);

                entity.ToTable("ToolCategory");

                entity.Property(e => e.ToolCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToolCategName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToolId>(entity =>
            {
                entity.HasKey(e => e.ToolLotNo);

                entity.ToTable("ToolID");

                entity.Property(e => e.ToolLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToolMount>(entity =>
            {
                entity.HasKey(e => new { e.MachineNo, e.OpeGroupCode, e.ToolLotNo, e.StartTime });

                entity.ToTable("ToolMount");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CheckOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndShotCount).HasMaxLength(1024);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartShotCount).HasMaxLength(1024);

                entity.Property(e => e.ToolCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolCategName).HasMaxLength(50);

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToolMountBefore20200801>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ToolMount_before_20200801");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndShotCount).HasMaxLength(1024);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartShotCount).HasMaxLength(1024);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.ToolCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolCategName).HasMaxLength(50);

                entity.Property(e => e.ToolLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToolMountBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ToolMount_bk");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.CheckOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CheckOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.CheckOperatorName).HasMaxLength(50);

                entity.Property(e => e.CheckTime).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndShotCount).HasMaxLength(1024);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartShotCount).HasMaxLength(1024);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.ToolCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolCategName).HasMaxLength(50);

                entity.Property(e => e.ToolLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToolMountT002Capillary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ToolMount_T002_Capillary");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndShotCount).HasMaxLength(1024);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartShotCount).HasMaxLength(1024);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.ToolCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolCategName).HasMaxLength(50);

                entity.Property(e => e.ToolLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ToolMountTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ToolMount_Temp");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndShotCount).HasMaxLength(1024);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartShotCount).HasMaxLength(1024);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.ToolCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolCategName).HasMaxLength(50);

                entity.Property(e => e.ToolLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TtldefectiveRateSnapShot>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo });

                entity.ToTable("TTLDefectiveRateSnapShot");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LastProcessEndTime).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TtldefectiveRateSnapShotOld>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ProcessSeqNo });

                entity.ToTable("TTLDefectiveRateSnapShot_OLD");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastProcessEndTime).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TtldefectiveRateUnscrapSnapShot>(entity =>
            {
                entity.HasKey(e => new { e.LotNo, e.LotNoSuffix, e.ScrapProcessSeqNo, e.ScrapDefectCode, e.UnScrapProcessSeqNo, e.UnScrapDefectCode });

                entity.ToTable("TTLDefectiveRateUnscrapSnapShot");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ScrapDefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnScrapDefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ScrapDefectName).HasMaxLength(20);

                entity.Property(e => e.ScrapProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ScrapProcessName).HasMaxLength(50);

                entity.Property(e => e.UnScrapDefectName).HasMaxLength(20);

                entity.Property(e => e.UnScrapProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UnScrapProcessName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TypeGroup>(entity =>
            {
                entity.HasKey(e => new { e.TypeGroup1, e.Type });

                entity.ToTable("TypeGroup");

                entity.Property(e => e.TypeGroup1)
                    .HasMaxLength(20)
                    .HasColumnName("TypeGroup");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TypeProductProcess>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode, e.ProcessCode });

                entity.ToTable("TypeProductProcess");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode).HasMaxLength(50);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Umt3rpm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UMT3RPM");

                entity.Property(e => e.F4).HasMaxLength(255);

                entity.Property(e => e.MachineNo).HasMaxLength(255);

                entity.Property(e => e.RohmPackage).HasMaxLength(255);

                entity.Property(e => e.Rpm).HasColumnName("RPM");
            });

            modelBuilder.Entity<UnProducingTime>(entity =>
            {
                entity.HasKey(e => new { e.LineId, e.StartTime, e.EndTime });

                entity.ToTable("UnProducingTime");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.HasKey(e => e.Unit1);

                entity.ToTable("Unit");

                entity.Property(e => e.Unit1)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Unit")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mlc21unit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("MLC21Unit")
                    .IsFixedLength();

                entity.Property(e => e.UnitName).HasMaxLength(10);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ValueList>(entity =>
            {
                entity.HasKey(e => new { e.ValueCode, e.Value });

                entity.ToTable("ValueList");

                entity.Property(e => e.ValueCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Value).HasMaxLength(50);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VewAlllotProgress>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewALLLotProgress");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputName1).HasMaxLength(50);

                entity.Property(e => e.OutputName2).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SEndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("S_EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.SEndOperatorName)
                    .HasMaxLength(50)
                    .HasColumnName("S_EndOperatorName");

                entity.Property(e => e.SEndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("S_EndTime");

                entity.Property(e => e.SInputQty).HasColumnName("S_InputQty");

                entity.Property(e => e.SMachineName)
                    .HasMaxLength(50)
                    .HasColumnName("S_MachineName");

                entity.Property(e => e.SMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("S_MachineNo")
                    .IsFixedLength();

                entity.Property(e => e.SStartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("S_StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.SStartOperatorName)
                    .HasMaxLength(50)
                    .HasColumnName("S_StartOperatorName");

                entity.Property(e => e.SStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("S_StartTime");

                entity.Property(e => e.STotalDefectQty).HasColumnName("S_TotalDefectQty");

                entity.Property(e => e.SmallProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SmallProcessName).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewAnalysisSheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewAnalysisSheet");

                entity.Property(e => e.AnalysisBaseProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AnalysisBaseProcessName)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.AnalysisEndTime).HasColumnType("datetime");

                entity.Property(e => e.AnalysisOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AnalysisOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisStartTime).HasColumnType("datetime");

                entity.Property(e => e.ControlNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode1)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode10)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode11)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode12)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode13)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode14)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode15)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode16)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode17)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode18)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode19)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode2)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode20)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode3)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode4)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode5)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode6)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode7)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode8)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCode9)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectName1)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName10)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName11)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName12)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName13)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName14)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName15)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName16)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName17)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName18)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName19)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName2)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName20)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName3)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName4)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName5)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName6)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName7)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName8)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.DefectName9)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessStartTime).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Result)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewAndonHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewAndonHistory");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AndonClassification).HasMaxLength(100);

                entity.Property(e => e.AndonDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ANDON_Date");

                entity.Property(e => e.Attender).HasMaxLength(50);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EngineerAttender).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("IPAddress")
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Memo).HasMaxLength(40);

                entity.Property(e => e.Ncnseq).HasColumnName("NCNSeq");

                entity.Property(e => e.NcnstatusCode)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("NCNStatusCode");

                entity.Property(e => e.Operator).HasMaxLength(50);

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.OperatorName).HasMaxLength(50);

                entity.Property(e => e.PlaceOfUse).HasMaxLength(20);

                entity.Property(e => e.Process).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Qcattender)
                    .HasMaxLength(50)
                    .HasColumnName("QCAttender");

                entity.Property(e => e.ReleasedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Released_Date");

                entity.Property(e => e.Section).HasMaxLength(20);

                entity.Property(e => e.Subject).HasMaxLength(30);

                entity.Property(e => e.TerminalName).HasMaxLength(40);

                entity.Property(e => e.TerminalType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TerminalTypeName).HasMaxLength(100);

                entity.Property(e => e.TreatmentTime).HasColumnName("Treatment_Time");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VewBlendLotInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewBlendLotInfo");

                entity.Property(e => e.ExpireDate).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .HasColumnName("TYPE")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewConversionUnit>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewConversionUnit");

                entity.Property(e => e.AfterUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BeforeUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VewDefect>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewDefect");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectName).HasMaxLength(20);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VewDefectDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewDefectDetail");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AnalysisEndTime).HasColumnType("datetime");

                entity.Property(e => e.AnalysisOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AnalysisOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisStartTime).HasColumnType("datetime");

                entity.Property(e => e.ControlNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessStartTime).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Result)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewDefectLotDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewDefectLotDetail");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AnalysisEndTime).HasColumnType("datetime");

                entity.Property(e => e.AnalysisOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AnalysisOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisStartTime).HasColumnType("datetime");

                entity.Property(e => e.ControlNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessStartTime).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Result)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewDefectLotInq>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewDefectLotInq");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.AnalysisEndTime).HasColumnType("datetime");

                entity.Property(e => e.AnalysisMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AnalysisOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("AnalysisOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.AnalysisStartTime).HasColumnType("datetime");

                entity.Property(e => e.ControlNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperatorName).HasMaxLength(50);

                entity.Property(e => e.ProcessStartTime).HasColumnType("datetime");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Result)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewGetLotItemDeviceCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewGetLotItemDeviceCheck");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID");

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FinalResult)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagSplitLot)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.OpeItemCategFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.SearchProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Search_ProductCode")
                    .IsFixedLength();

                entity.Property(e => e.SearchType)
                    .HasMaxLength(20)
                    .HasColumnName("Search_Type");

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID");

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewGetMachineSupplement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewGetMachineSupplement");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.StopMin).HasColumnName("STOP_MIN");

                entity.Property(e => e.SupplementCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unit).HasMaxLength(10);
            });

            modelBuilder.Entity<VewGetMaterialMounts01>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewGetMaterialMounts01");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProductChange)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VewGetMaterialSupplement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewGetMaterialSupplement");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SupplementCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.UsingMin).HasColumnName("USING_MIN");
            });

            modelBuilder.Entity<VewGetToolSupplement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewGetToolSupplement");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SupplementCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.UsingMin).HasColumnName("USING_MIN");
            });

            modelBuilder.Entity<VewGetlotProgressMaterialMount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewGETLotProgressMaterialMount");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.InputUnitName).HasMaxLength(10);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OutputUnitName).HasMaxLength(10);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewInfoLotMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewInfoLotMaterial");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewInfoLotMaterialDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewInfoLotMaterialDetail");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewInfoLotTool>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewInfoLotTool");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.ToolCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolCategName).HasMaxLength(50);

                entity.Property(e => e.ToolLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ToolLotNoSuffix)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewInfoLotToolDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewInfoLotToolDetail");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.ToolCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToolCategName).HasMaxLength(50);

                entity.Property(e => e.ToolLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ToolLotNoSuffix)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ToolName).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewInfoLotTrouble>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewInfoLotTrouble");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.StopMin).HasColumnName("STOP_MIN");

                entity.Property(e => e.SupplementCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unit).HasMaxLength(10);
            });

            modelBuilder.Entity<VewInfomationItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewInfomationItem");

                entity.Property(e => e.Calculation)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DataType).HasMaxLength(10);

                entity.Property(e => e.DefaultValue).HasMaxLength(50);

                entity.Property(e => e.InputKind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemInputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Remarks1).HasMaxLength(50);

                entity.Property(e => e.Remarks2).HasMaxLength(50);

                entity.Property(e => e.Remarks3).HasMaxLength(50);

                entity.Property(e => e.Remarks4).HasMaxLength(50);

                entity.Property(e => e.Remarks5).HasMaxLength(50);

                entity.Property(e => e.RemarksColor1)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor2)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor3)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor4)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor5)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksTitle1).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle2).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle3).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle4).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle5).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.ValueCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewLeadTimeSec>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLeadTimeSec");

                entity.Property(e => e.BaseTime).HasColumnType("numeric(38, 5)");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewLineFirstMachineNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLineFirstMachineNo");

                entity.Property(e => e.FirstMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlowId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FlowID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewLineMachineType>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLineMachineType");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewLotDefectDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotDefectDetail");

                entity.Property(e => e.Countday).HasColumnName("COUNTDAY");

                entity.Property(e => e.Countday2)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("COUNTDAY2");

                entity.Property(e => e.Countmonth).HasColumnName("COUNTMONTH");

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectGroupName).HasMaxLength(20);

                entity.Property(e => e.DefectName).HasMaxLength(20);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FirstMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<VewLotDefectDetailChild>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotDefectDetail_Child");

                entity.Property(e => e.Countday).HasColumnName("COUNTDAY");

                entity.Property(e => e.Countday2)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("COUNTDAY2");

                entity.Property(e => e.Countmonth).HasColumnName("COUNTMONTH");

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectGroupName).HasMaxLength(20);

                entity.Property(e => e.DefectName).HasMaxLength(20);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FirstMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<VewLotDefectListFl330>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotDefectList_FL330");

                entity.Property(e => e.Bari).HasColumnName("BARI");

                entity.Property(e => e.ChipDc).HasColumnName("CHIP DC");

                entity.Property(e => e.ChipH).HasColumnName("CHIP H");

                entity.Property(e => e.ChipHFe).HasColumnName("CHIP hFE");

                entity.Property(e => e.Dc).HasColumnName("DC");

                entity.Property(e => e.DefectiveRate)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DetailSeqNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.Forming).HasColumnName("FORMING");

                entity.Property(e => e.Hfe).HasColumnName("HFE");

                entity.Property(e => e.InTape).HasColumnName("IN TAPE");

                entity.Property(e => e.Laser).HasColumnName("LASER");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Lownoise).HasColumnName("LOWNOISE");

                entity.Property(e => e.Machine).HasColumnName("MACHINE");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mark).HasColumnName("MARK");

                entity.Property(e => e.Material).HasColumnName("MATERIAL");

                entity.Property(e => e.Mold).HasColumnName("MOLD");

                entity.Property(e => e.MoldBs).HasColumnName("MOLD BS");

                entity.Property(e => e.Os1).HasColumnName("OS1");

                entity.Property(e => e.Os2).HasColumnName("OS2");

                entity.Property(e => e.Other).HasColumnName("OTHER");

                entity.Property(e => e.OtherB).HasColumnName("OTHER B");

                entity.Property(e => e.Package).HasColumnName("PACKAGE");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProcessTime)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sample).HasColumnName("SAMPLE");

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SurF).HasColumnName("Sur F");

                entity.Property(e => e.SurR).HasColumnName("Sur R");

                entity.Property(e => e.Sus1).HasColumnName("SUS1");

                entity.Property(e => e.Sus2).HasColumnName("SUS2");

                entity.Property(e => e.TactTime)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.Unclear).HasColumnName("UNCLEAR");

                entity.Property(e => e.WaitTime)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VewLotDefectParamInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotDefectParamInfo");

                entity.Property(e => e.Countday).HasColumnName("COUNTDAY");

                entity.Property(e => e.Countday2)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("COUNTDAY2");

                entity.Property(e => e.Countmonth).HasColumnName("COUNTMONTH");

                entity.Property(e => e.Countyear).HasColumnName("COUNTYEAR");

                entity.Property(e => e.Countym)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("COUNTYM");

                entity.Property(e => e.Countymd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("COUNTYMD");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("TYPE");

                entity.Property(e => e.WeekMark)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewLotDefectParamInfoChild>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotDefectParamInfo_Child");

                entity.Property(e => e.Countday).HasColumnName("COUNTDAY");

                entity.Property(e => e.Countday2)
                    .HasMaxLength(61)
                    .IsUnicode(false)
                    .HasColumnName("COUNTDAY2");

                entity.Property(e => e.Countmonth).HasColumnName("COUNTMONTH");

                entity.Property(e => e.Countyear).HasColumnName("COUNTYEAR");

                entity.Property(e => e.Countym)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("COUNTYM");

                entity.Property(e => e.Countymd)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("COUNTYMD");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("TYPE");

                entity.Property(e => e.WeekMark)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewLotItemList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotItemList");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID");

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FinalResult)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagSplitLot)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.OpeItemCategFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCategName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SearchProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Search_ProductCode")
                    .IsFixedLength();

                entity.Property(e => e.SearchType)
                    .HasMaxLength(20)
                    .HasColumnName("Search_Type");

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID");

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewLotItemListDeviceCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotItemListDeviceCheck");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID");

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FinalResult)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlagSplitLot)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.OpeItemCategFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SearchProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Search_ProductCode")
                    .IsFixedLength();

                entity.Property(e => e.SearchType)
                    .HasMaxLength(20)
                    .HasColumnName("Search_Type");

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID");

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewLotMaterialHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotMaterialHistory");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewLotMaterialTool>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotMaterialTool");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewLotOperationItemCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotOperationItemCheck");

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Result).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VewLotProgress>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotProgress");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContinuousStartFlg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndCarrierCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndCarrierSet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndPlanTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.InputLotCount).HasColumnType("numeric(4, 3)");

                entity.Property(e => e.InputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputUnitName).HasMaxLength(10);

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineAlarmTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineEndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineProductionTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStartTime).HasColumnType("datetime");

                entity.Property(e => e.MachineStopTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ncnno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("NCNNo")
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputLotCount).HasColumnType("numeric(4, 3)");

                entity.Property(e => e.OutputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputUnitName).HasMaxLength(10);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductionDate).HasColumnType("date");

                entity.Property(e => e.QtyCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegistType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SplitLot)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierSet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartPlanTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SurplusSucceed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateCarrierEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateMaterialEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdateToolEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WipcontrolEnd).HasColumnName("WIPControlEnd");
            });

            modelBuilder.Entity<VewLotProgressForLt>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotProgressForLT");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewLotProgressForLt20180329>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vewLotProgressForLT_20180329");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewLotProgressMaterialToolMount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotProgressMaterialToolMount");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID");

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.InputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputUnitName).HasMaxLength(10);

                entity.Property(e => e.LotEndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Lot_EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.LotEndOperatorName)
                    .HasMaxLength(50)
                    .HasColumnName("Lot_EndOperatorName");

                entity.Property(e => e.LotEndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Lot_EndTime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotStartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Lot_StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.LotStartOperatorName)
                    .HasMaxLength(50)
                    .HasColumnName("Lot_StartOperatorName");

                entity.Property(e => e.LotStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Lot_StartTime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialToolCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("Material_Tool_Categ");

                entity.Property(e => e.MaterialToolCategName)
                    .HasMaxLength(30)
                    .HasColumnName("Material_Tool_CategName");

                entity.Property(e => e.MaterialToolDefectLotNo)
                    .HasMaxLength(50)
                    .HasColumnName("Material_Tool_Defect_LotNo");

                entity.Property(e => e.MaterialToolDefectLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Material_Tool_Defect_LotNoSuffix");

                entity.Property(e => e.MaterialToolDefectName)
                    .HasMaxLength(50)
                    .HasColumnName("Material_Tool_Defect_Name");

                entity.Property(e => e.MaterialToolDefectQty).HasColumnName("Material_Tool_Defect_Qty");

                entity.Property(e => e.MaterialToolEndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Material_Tool_EndTime");

                entity.Property(e => e.MaterialToolFlag).HasColumnName("Material_Tool_Flag");

                entity.Property(e => e.MaterialToolStartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("Material_Tool_StartTime");

                entity.Property(e => e.OpeGroupCode).HasMaxLength(100);

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.OutputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputUnitName).HasMaxLength(10);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SortEndTime).HasColumnType("datetime");

                entity.Property(e => e.SortExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.SortStartTime).HasColumnType("datetime");

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID");

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewLotResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotResult");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Operator).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VewLotResultProdQtyMatLedger>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotResultProdQty_MatLedger");

                entity.Property(e => e.DepartName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DeptMc)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DeptMC");

                entity.Property(e => e.DeptMctype)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DeptMCType");

                entity.Property(e => e.DeptType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DeptTypeProcessCd2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("DeptTypeProcessCD2");

                entity.Property(e => e.DeptTypeProcessName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Orgline)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ORGLine");

                entity.Property(e => e.Process).HasMaxLength(50);

                entity.Property(e => e.ProcessCd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ProcessCD");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewLotSplitHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotSplitHistory");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSub)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotSplitProcess)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PLotNoSub)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("P_LotNoSub")
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewLotStopLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotStopLine");

                entity.Property(e => e.AbnormalName).HasMaxLength(50);

                entity.Property(e => e.AbnormalReason).HasMaxLength(800);

                entity.Property(e => e.CompleteDate).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineGroupName).HasMaxLength(50);

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RegistDate).HasColumnType("datetime");

                entity.Property(e => e.RegistOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("RegistOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.RegistOperatorName).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewLotTimeLimitResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewLotTimeLimitResult");

                entity.Property(e => e.AutoAndon)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromProcessName).HasMaxLength(50);

                entity.Property(e => e.FromProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FromProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.FromResultTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Result)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToLimitPlanTime).HasColumnType("datetime");

                entity.Property(e => e.ToProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToProcessName)
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.ToProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ToProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.ToResultTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VewMachine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewMachine");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParentMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StatusCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewMachineMonitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewMachineMonitoring");

                entity.Property(e => e.Carrier).HasMaxLength(1024);

                entity.Property(e => e.DeviceCheck).HasMaxLength(1024);

                entity.Property(e => e.Line)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Material).HasMaxLength(1024);

                entity.Property(e => e.Process).HasMaxLength(58);

                entity.Property(e => e.ProcessingLot)
                    .HasMaxLength(1024)
                    .IsUnicode(false)
                    .HasColumnName("Processing Lot");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Tool).HasMaxLength(1024);
            });

            modelBuilder.Entity<VewMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewMaterial");

                entity.Property(e => e.LogisticsUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LogisticsUnitName).HasMaxLength(10);

                entity.Property(e => e.MakerCode).HasMaxLength(50);

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCategory)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCategoryGroup)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.MaterialSpec).HasMaxLength(74);

                entity.Property(e => e.MaterialYieldRate).HasColumnType("decimal(4, 3)");

                entity.Property(e => e.MinInQty).HasColumnType("decimal(15, 6)");

                entity.Property(e => e.Unit)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UnitName).HasMaxLength(10);
            });

            modelBuilder.Entity<VewMaterialBak20180607>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vewMaterial_bak20180607");

                entity.Property(e => e.BaseOfExpirePriod).HasMaxLength(40);

                entity.Property(e => e.ConversionCoefficient)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MakerCode).HasMaxLength(50);

                entity.Property(e => e.MaterialCategory)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(74);

                entity.Property(e => e.MinInQty).HasColumnType("decimal(12, 3)");

                entity.Property(e => e.Operator)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StockInUnit).HasMaxLength(10);

                entity.Property(e => e.StockUnit).HasMaxLength(10);

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.Warehouse)
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VewMatomeLot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewMatomeLot");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParentLotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParentLotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewMlc21lot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewMLC21Lot");

                entity.Property(e => e.InputDate).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mlc21process)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("MLC21Process")
                    .IsFixedLength();

                entity.Property(e => e.Mlc21statusCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MLC21StatusCode")
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewOperation>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewOperation");

                entity.Property(e => e.BarcodeQrformat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("BarcodeQRFormat")
                    .IsFixedLength();

                entity.Property(e => e.ChangeDisableStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ChangeMachineStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Equipment)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputItemControl)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputKind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputQtyUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputQtyUnitName).HasMaxLength(10);

                entity.Property(e => e.InputRemainQty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputSetQty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputUseQty)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoInputFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.OpeScope)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.SpecialOperate)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SpecialOperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartEndFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewOperatorRoleApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewOperatorRoleApplication");

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.RoleId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("RoleID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewOperatorRoleObject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewOperatorRoleObject");

                entity.Property(e => e.ApplicationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DisabledObject)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("OperatorID")
                    .IsFixedLength();

                entity.Property(e => e.RoleId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("RoleID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewPrdEndProcess>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewPrdEndProcess");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewProcess>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewProcess");

                entity.Property(e => e.DispProcessCode).HasMaxLength(53);

                entity.Property(e => e.DispProcessName).HasMaxLength(108);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessGroup).HasMaxLength(50);

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(50);
            });

            modelBuilder.Entity<VewProcessFlow>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewProcessFlow");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewProductRoute>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewProductRoute");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HFerank)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("hFERank")
                    .IsFixedLength();

                entity.Property(e => e.OperatorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pack)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Pgcode).HasColumnName("PGCode");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RohmLine)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RohmProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RouteNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Spec)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Trno)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("TRNo")
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VewProductionStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewProductionStatus");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ResultOutUnitLot)
                    .HasColumnType("numeric(16, 3)")
                    .HasColumnName("Result_OutUnit_Lot");

                entity.Property(e => e.ResultOutUnitPunit)
                    .HasColumnType("numeric(16, 3)")
                    .HasColumnName("Result_OutUnit_PUnit");

                entity.Property(e => e.ResultRsltUnitLot)
                    .HasColumnType("numeric(4, 3)")
                    .HasColumnName("Result_RsltUnit_Lot");

                entity.Property(e => e.ResultRsltUnitPunit).HasColumnName("Result_RsltUnit_PUnit");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewProductionStatusBk>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewProductionStatus_BK");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ResultOutUnitLot)
                    .HasColumnType("numeric(16, 3)")
                    .HasColumnName("Result_OutUnit_Lot");

                entity.Property(e => e.ResultOutUnitPunit)
                    .HasColumnType("numeric(16, 3)")
                    .HasColumnName("Result_OutUnit_PUnit");

                entity.Property(e => e.ResultRsltUnitLot)
                    .HasColumnType("numeric(4, 3)")
                    .HasColumnName("Result_RsltUnit_Lot");

                entity.Property(e => e.ResultRsltUnitPunit).HasColumnName("Result_RsltUnit_PUnit");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewProductionStatusTest>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewProductionStatus_TEST");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ResultOutUnitLot)
                    .HasColumnType("numeric(16, 3)")
                    .HasColumnName("Result_OutUnit_Lot");

                entity.Property(e => e.ResultOutUnitPunit)
                    .HasColumnType("numeric(16, 3)")
                    .HasColumnName("Result_OutUnit_PUnit");

                entity.Property(e => e.ResultRsltUnitLot)
                    .HasColumnType("numeric(4, 3)")
                    .HasColumnName("Result_RsltUnit_Lot");

                entity.Property(e => e.ResultRsltUnitPunit).HasColumnName("Result_RsltUnit_PUnit");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewReferenceLot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewReferenceLot");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID");

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FlagSplitLot)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputUnitName).HasMaxLength(10);

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputName1).HasMaxLength(50);

                entity.Property(e => e.OutputName2).HasMaxLength(50);

                entity.Property(e => e.OutputUnit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputUnitName).HasMaxLength(10);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCategName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProgressData)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SearchProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Search_ProductCode")
                    .IsFixedLength();

                entity.Property(e => e.SearchType)
                    .HasMaxLength(20)
                    .HasColumnName("Search_Type");

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID");

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TactTime).HasColumnType("numeric(20, 5)");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewReprintProductLabelHist>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewReprintProductLabelHist");

                entity.Property(e => e.BarCode1)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BarCode2)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerProductCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Marking)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mno)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("MNo");

                entity.Property(e => e.Pbfree)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PBFree");

                entity.Property(e => e.Qrcode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("QRCode");

                entity.Property(e => e.Reason)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReelNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ReelQty)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ReprintDate).HasColumnType("datetime");

                entity.Property(e => e.ReprintOperatorId)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ReprintOperatorID");

                entity.Property(e => e.ReprintOperatorName)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.RohmproductCode)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ROHMProductCode");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserPartsNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VewSerialTimeLimitResult>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewSerialTimeLimitResult");

                entity.Property(e => e.AutoAndon)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FromProcessName).HasMaxLength(50);

                entity.Property(e => e.FromProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("FromProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.FromResultTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Result)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sign)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToLimitPlanTime).HasColumnType("datetime");

                entity.Property(e => e.ToProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ToProcessName).HasMaxLength(50);

                entity.Property(e => e.ToProcessSe)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ToProcessSE")
                    .IsFixedLength();

                entity.Property(e => e.ToResultTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VewSupplementItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewSupplementItem");

                entity.Property(e => e.Calculation)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DataType).HasMaxLength(10);

                entity.Property(e => e.DefaultValue).HasMaxLength(50);

                entity.Property(e => e.InputKind)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemInputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.Remarks1).HasMaxLength(50);

                entity.Property(e => e.Remarks2).HasMaxLength(50);

                entity.Property(e => e.Remarks3).HasMaxLength(50);

                entity.Property(e => e.Remarks4).HasMaxLength(50);

                entity.Property(e => e.Remarks5).HasMaxLength(50);

                entity.Property(e => e.RemarksColor1)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor2)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor3)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor4)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor5)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksTitle1).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle2).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle3).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle4).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle5).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.ValueCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ztcname)
                    .HasMaxLength(50)
                    .HasColumnName("ZTCName");
            });

            modelBuilder.Entity<VewSupplementItemBk20191218>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewSupplementItem_bk20191218");

                entity.Property(e => e.Calculation)
                    .HasMaxLength(256)
                    .IsUnicode(false);

                entity.Property(e => e.DataType).HasMaxLength(10);

                entity.Property(e => e.DefaultValue).HasMaxLength(50);

                entity.Property(e => e.InputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCategName).HasMaxLength(50);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemInputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.Remarks1).HasMaxLength(50);

                entity.Property(e => e.Remarks2).HasMaxLength(50);

                entity.Property(e => e.Remarks3).HasMaxLength(50);

                entity.Property(e => e.Remarks4).HasMaxLength(50);

                entity.Property(e => e.Remarks5).HasMaxLength(50);

                entity.Property(e => e.RemarksColor1)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor2)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor3)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor4)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksColor5)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RemarksTitle1).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle2).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle3).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle4).HasMaxLength(50);

                entity.Property(e => e.RemarksTitle5).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.ValueCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ztcname)
                    .HasMaxLength(50)
                    .HasColumnName("ZTCName");
            });

            modelBuilder.Entity<VewSynonymlot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewSynonymlot");

                entity.Property(e => e.CompleteDate).HasColumnType("datetime");

                entity.Property(e => e.InputDate).HasColumnType("datetime");

                entity.Property(e => e.InputProcCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputDate).HasColumnType("datetime");

                entity.Property(e => e.OutputProcCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ReceivingCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RohmProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RouteNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Sline)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("SLine")
                    .IsFixedLength();

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewTenkenMaintenance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewTenkenMaintenance");

                entity.Property(e => e.Endtime).HasColumnType("datetime");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OpeGroupName).HasMaxLength(50);

                entity.Property(e => e.ParentMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewTypeGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewTypeGroup");

                entity.Property(e => e.Type).HasMaxLength(23);
            });

            modelBuilder.Entity<VewTypeGroupProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewTypeGroupProduct");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.TypeGroup).HasMaxLength(23);
            });

            modelBuilder.Entity<VewTypeNcim>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewTypeNcim");

                entity.Property(e => e.Line)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Operator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperatorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VewUnApproveCheckAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewUnApproveCheckAll");

                entity.Property(e => e.ApproveDate).HasColumnType("datetime");

                entity.Property(e => e.ApproveId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ApproveID")
                    .IsFixedLength();

                entity.Property(e => e.CycleCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ManageClassName)
                    .HasMaxLength(60)
                    .HasColumnName("manage_class_name");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StandardName).HasMaxLength(100);

                entity.Property(e => e.StandardNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WorkCategory)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.WorkStartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<VewUnitPrice>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewUnitPrice");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VewWipLot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewWipLot");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndPlanTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FirstMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineAlarmTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineEndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineProductionTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStartTime).HasColumnType("datetime");

                entity.Property(e => e.MachineStopTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MoniProc)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartPlanTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VewWipLotForFifo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewWipLotForFIFO");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndPlanTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FirstEndTime).HasColumnType("datetime");

                entity.Property(e => e.FirstMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineAlarmTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineEndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineProductionTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStartTime).HasColumnType("datetime");

                entity.Property(e => e.MachineStopTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MoniProc)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartPlanTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VewWipLotForPoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewWipLotForPOC");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndPlanTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FirstMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineAlarmTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineEndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineProductionTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStartTime).HasColumnType("datetime");

                entity.Property(e => e.MachineStopTime)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MoniProc)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartPlanTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VewWipLotReference>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewWipLotReference");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndPlanTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.InputDate).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineGroupName).HasMaxLength(50);

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OutputDate).HasColumnType("datetime");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartPlanTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.Unit)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UnitName).HasMaxLength(10);
            });

            modelBuilder.Entity<VewWipLotReferenceBak20161108>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("_vewWipLotReference_bak20161108");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndPlanTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineGroupName).HasMaxLength(50);

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartPlanTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewWipLotReferenceBak20200402>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewWipLotReference_bak20200402");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndPlanTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineGroupName).HasMaxLength(50);

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartPlanTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.Unit)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UnitName).HasMaxLength(10);
            });

            modelBuilder.Entity<VewWiplotSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewWIPLotSummary");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.ProcessCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.WiplotCount).HasColumnName("WIPLotCount");
            });

            modelBuilder.Entity<VewWipmonitoring>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewWIPMonitoring");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.ProcessCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.WiplotCount).HasColumnName("WIPLotCount");

                entity.Property(e => e.Wipqty).HasColumnName("WIPQty");

                entity.Property(e => e.Wipunit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WIPUnit")
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewWipprevLot>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewWIPPrevLot");

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndPlanTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.InputDate).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartPlanTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<VewXrayFifo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewXRayFIFO");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<VewZchart>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vewZchart");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OrderNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ResultCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ResultTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectName).HasMaxLength(20);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<View2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_2");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.InputQty).HasColumnName("inputQty");

                entity.Property(e => e.Lotno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.OpeGroupName)
                    .HasMaxLength(50)
                    .HasColumnName("OPeGroupName");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<WebApiparameter>(entity =>
            {
                entity.HasKey(e => new { e.ParameterCode, e.ParameterName });

                entity.ToTable("WebAPIParameter");

                entity.Property(e => e.ParameterCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ParameterName).HasMaxLength(50);

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParameterValue).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WipControlProductCateg>(entity =>
            {
                entity.HasKey(e => new { e.LineId, e.ProductCateg });

                entity.ToTable("WipControlProductCateg");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WipProcessControl>(entity =>
            {
                entity.HasKey(e => new { e.LineGroupId, e.LineId, e.CheckProcessCode });

                entity.ToTable("WipProcessControl");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.CheckProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaxWiplotCount)
                    .HasColumnType("numeric(12, 3)")
                    .HasColumnName("MaxWIPLotCount");

                entity.Property(e => e.ToProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Wipmonitoring>(entity =>
            {
                entity.HasKey(e => new { e.LineId, e.ProcessSeqNo });

                entity.ToTable("WIPMonitoring");

                entity.HasIndex(e => e.LineId, "IDX1_WIPMonitoring");

                entity.HasIndex(e => e.ProcessCode, "IDX2_WIPMonitoring");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WiplotCount)
                    .HasColumnType("numeric(12, 3)")
                    .HasColumnName("WIPLotCount");

                entity.Property(e => e.Wipqty).HasColumnName("WIPQty");

                entity.Property(e => e.Wipunit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WIPUnit")
                    .IsFixedLength();
            });

            modelBuilder.Entity<WipmonitoringSnapShot>(entity =>
            {
                entity.HasKey(e => new { e.FromDate, e.LineId, e.ProcessSeqNo });

                entity.ToTable("WIPMonitoringSnapShot");

                entity.Property(e => e.FromDate).HasColumnType("date");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WiplotCount).HasColumnName("WIPLotCount");

                entity.Property(e => e.Wipqty).HasColumnName("WIPQty");

                entity.Property(e => e.Wipunit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WIPUnit")
                    .IsFixedLength();
            });

            modelBuilder.Entity<WipsnapShot>(entity =>
            {
                entity.HasKey(e => new { e.SnapShotDate, e.LotNo, e.LotNoSuffix, e.ProcessSeqNo });

                entity.ToTable("WIPSnapShot");

                entity.Property(e => e.SnapShotDate).HasColumnType("date");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.LotStatus)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MonitorProcessCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MonitorProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MonitorProcessName).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WiplotCount).HasColumnName("WIPLotCount");

                entity.Property(e => e.Wipqty).HasColumnName("WIPQty");

                entity.Property(e => e.Wipunit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("WIPUnit")
                    .IsFixedLength();
            });

            modelBuilder.Entity<WsrouteNo>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode, e.ProductCateg });

                entity.ToTable("WSRouteNo");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RouteNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZLottraceDelete>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zLOTTRACE_DELETE");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZLottraceDeleteRecovery>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zLOTTRACE_DELETE_RECOVERY");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZLottraceLotDefectMpt3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("z_Lottrace_lot_defect_mpt3");

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectName).HasMaxLength(20);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NcimProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("NCIM_ProcessCode")
                    .IsFixedLength();

                entity.Property(e => e.NcimProcessName)
                    .HasMaxLength(50)
                    .HasColumnName("NCIM_ProcessName");

                entity.Property(e => e.Operator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode3rd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode8th)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZLottraceLotDefectMpt3mc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("z_Lottrace_lot_defect_mpt3mc");

                entity.Property(e => e.DefectCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefectName).HasMaxLength(20);

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NcimProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("NCIM_ProcessCode")
                    .IsFixedLength();

                entity.Property(e => e.NcimProcessName)
                    .HasMaxLength(50)
                    .HasColumnName("NCIM_ProcessName");

                entity.Property(e => e.Operator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode3rd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode8th)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZLottraceLotResultMpt3>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("z_Lottrace_lot_result_mpt3");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NcimProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("NCIM_ProcessCode")
                    .IsFixedLength();

                entity.Property(e => e.NcimProcessName)
                    .HasMaxLength(50)
                    .HasColumnName("NCIM_ProcessName");

                entity.Property(e => e.Operator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode3rd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode8th)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZLottraceLotResultMpt3mc>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("z_Lottrace_lot_result_mpt3mc");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NcimProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("NCIM_ProcessCode")
                    .IsFixedLength();

                entity.Property(e => e.NcimProcessName)
                    .HasMaxLength(50)
                    .HasColumnName("NCIM_ProcessName");

                entity.Property(e => e.Operator)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode3rd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode8th)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZMmaterialLotWafer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zMMaterial_Lot_WAFER");

                entity.Property(e => e.ExpireDate).HasColumnType("date");

                entity.Property(e => e.MakerCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCategoryName)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Unit)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Warehouse)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZOperationItemCateg20210816>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zOperationItemCateg_20210816");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZProductFlow>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("z_ProductFlow");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlowId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FlowID")
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZVewProductMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("z_vewProduct_master");

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RouteNo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZtccountUpForLotEnd>(entity =>
            {
                entity.HasKey(e => new { e.Ztccateg, e.Ztcname, e.Type, e.ProductCode });

                entity.ToTable("ZTCCountUpForLotEnd");

                entity.Property(e => e.Ztccateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ZTCCateg")
                    .IsFixedLength();

                entity.Property(e => e.Ztcname)
                    .HasMaxLength(50)
                    .HasColumnName("ZTCName");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InOrOut)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZtclimitCtrl>(entity =>
            {
                entity.HasKey(e => new { e.Ztccateg, e.Ztcname, e.ConditionNo });

                entity.ToTable("ZTCLimitCtrl");

                entity.Property(e => e.Ztccateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ZTCCateg")
                    .IsFixedLength();

                entity.Property(e => e.Ztcname)
                    .HasMaxLength(50)
                    .HasColumnName("ZTCName");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.BaseTimeOpeCateg1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BaseTimeOpeCateg2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BaseTimeOpeCateg3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BaseTimeOpeCode1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BaseTimeOpeCode2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BaseTimeOpeCode3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckCateg1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckCateg2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckCateg3)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckOpeCode1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckOpeCode2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CheckOpeCode3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionName).HasMaxLength(50);

                entity.Property(e => e.CountClearOpeCode1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountClearOpeCode2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountClearOpeCode3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountUpOpeCode1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountUpOpeCode2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CountUpOpeCode3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZtclimitTran>(entity =>
            {
                entity.HasKey(e => new { e.Ztccateg, e.Ztcno, e.ZtcnoSuffix, e.ConditionNo });

                entity.ToTable("ZTCLimitTrans");

                entity.Property(e => e.Ztccateg)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ZTCCateg")
                    .IsFixedLength();

                entity.Property(e => e.Ztcno)
                    .HasMaxLength(50)
                    .HasColumnName("ZTCNo");

                entity.Property(e => e.ZtcnoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("ZTCNoSuffix");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.BaseTime).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConditionName).HasMaxLength(50);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ztcname)
                    .HasMaxLength(50)
                    .HasColumnName("ZTCName");
            });

            modelBuilder.Entity<ZvewMasterDeviceCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zvew_Master_Device_Check");

                entity.Property(e => e.InputItemDataType)
                    .HasMaxLength(10)
                    .HasColumnName("InputItem_DataType");

                entity.Property(e => e.InputItemInputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("InputItem_InputOption")
                    .IsFixedLength();

                entity.Property(e => e.InputItemInputType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("InputItem_InputType");

                entity.Property(e => e.InputItemItemName)
                    .HasMaxLength(50)
                    .HasColumnName("InputItem_ItemName");

                entity.Property(e => e.InputItemListDisplayOrder).HasColumnName("InputItemList_DisplayOrder");

                entity.Property(e => e.InputItemListItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("InputItemList_ItemCode")
                    .IsFixedLength();

                entity.Property(e => e.InputItemReadOnly).HasColumnName("InputItem_ReadOnly");

                entity.Property(e => e.InputItemUnit)
                    .HasMaxLength(10)
                    .HasColumnName("InputItem_Unit");

                entity.Property(e => e.InputItemValueCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("InputItem_ValueCode")
                    .IsFixedLength();

                entity.Property(e => e.ItemCategoryItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ItemCategory_ItemCateg")
                    .IsFixedLength();

                entity.Property(e => e.ItemCategoryItemCategName)
                    .HasMaxLength(50)
                    .HasColumnName("ItemCategory_ItemCategName");

                entity.Property(e => e.ItemCategoryRemarks1)
                    .HasMaxLength(50)
                    .HasColumnName("ItemCategory_Remarks1");

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationItemCategDisplayOrder).HasColumnName("OperationItemCateg_DisplayOrder");

                entity.Property(e => e.OperationItemCategInputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("OperationItemCateg_InputOption")
                    .IsFixedLength();

                entity.Property(e => e.OperationItemCategItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("OperationItemCateg_ItemCateg")
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);
            });

            modelBuilder.Entity<ZvewMasterSupplementCheck>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zvew_Master_Supplement_Check");

                entity.Property(e => e.InputItemDataType)
                    .HasMaxLength(10)
                    .HasColumnName("InputItem_DataType");

                entity.Property(e => e.InputItemInputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("InputItem_InputOption")
                    .IsFixedLength();

                entity.Property(e => e.InputItemInputType)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("InputItem_InputType");

                entity.Property(e => e.InputItemItemCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("InputItem_ItemCode")
                    .IsFixedLength();

                entity.Property(e => e.InputItemItemName)
                    .HasMaxLength(50)
                    .HasColumnName("InputItem_ItemName");

                entity.Property(e => e.InputItemListDisplayOrder).HasColumnName("InputItemList_DisplayOrder");

                entity.Property(e => e.InputItemReadOnly).HasColumnName("InputItem_ReadOnly");

                entity.Property(e => e.InputItemUnit)
                    .HasMaxLength(10)
                    .HasColumnName("InputItem_Unit");

                entity.Property(e => e.InputItemValueCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("InputItem_ValueCode")
                    .IsFixedLength();

                entity.Property(e => e.ItemCategoryItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("ItemCategory_ItemCateg")
                    .IsFixedLength();

                entity.Property(e => e.ItemCategoryItemCategName)
                    .HasMaxLength(50)
                    .HasColumnName("ItemCategory_ItemCategName");

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationName).HasMaxLength(50);

                entity.Property(e => e.SupplementItemCategDisplayOrder).HasColumnName("SupplementItemCateg_DisplayOrder");

                entity.Property(e => e.SupplementItemCategInputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SupplementItemCateg_InputOption")
                    .IsFixedLength();

                entity.Property(e => e.SupplementItemCategItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("SupplementItemCateg_ItemCateg")
                    .IsFixedLength();

                entity.Property(e => e.SupplementItemCategMachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("SupplementItemCateg_MachineNo")
                    .IsFixedLength();

                entity.Property(e => e.Value).HasMaxLength(50);
            });

            modelBuilder.Entity<ZvewWacollationNcim>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zvew_wacollation_ncim");

                entity.Property(e => e.MachineCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.PartsNo)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZvewWacollationNcimCount>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zvew_wacollation_ncim_count");

                entity.Property(e => e.MachineCateg)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SlotNo)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZzCheckDeviceCheckOtherProcess>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzCheck_Device_Check_other_process");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZzCheckMiddleProcess>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzCheckMiddleProcess");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndCarrierCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndCarrierSet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EndOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.EndOperatorName).HasMaxLength(50);

                entity.Property(e => e.EndPlanTime).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineAlarmTime)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineEndTime).HasColumnType("datetime");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineProductionTime)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineStartTime).HasColumnType("datetime");

                entity.Property(e => e.MachineStopTime)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductFamily)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SplitLot)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierSet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("StartOperatorID")
                    .IsFixedLength();

                entity.Property(e => e.StartOperatorName).HasMaxLength(50);

                entity.Property(e => e.StartPlanTime).HasColumnType("datetime");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.SurplusSucceed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZzCheckProcessnameNotShowLotmatenance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_check_processname_not_show_lotmatenance");

                entity.Property(e => e.ProcessCode).HasMaxLength(57);
            });

            modelBuilder.Entity<ZzLineM>(entity =>
            {
                entity.HasKey(e => e.LineId);

                entity.ToTable("zzLineM");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.MaxWiplotCount).HasColumnName("MaxWIPLotCount");

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZzLineMachineW010>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zzLineMachine_W010");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZzMachine>(entity =>
            {
                entity.HasKey(e => e.MachineNo);

                entity.ToTable("zzMachine");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LicenseNo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZzMachineResin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzMachineResin");

                entity.Property(e => e.EndOperator).HasMaxLength(61);

                entity.Property(e => e.EndTime)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiredDate)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg).HasMaxLength(33);

                entity.Property(e => e.MaterialCategCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.OpeGroup).HasMaxLength(55);

                entity.Property(e => e.OpeGroupCode)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Process).HasMaxLength(57);

                entity.Property(e => e.SortEndTime).HasColumnType("datetime");

                entity.Property(e => e.SortExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.SortStartTime).HasColumnType("datetime");

                entity.Property(e => e.SpecificationsFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StartOperator).HasMaxLength(61);

                entity.Property(e => e.StartTime)
                    .HasMaxLength(36)
                    .IsUnicode(false);

                entity.Property(e => e.StartTimeKey)
                    .HasMaxLength(61)
                    .IsUnicode(false);

                entity.Property(e => e.SupplementItemFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZzMaterialToolResin>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzMaterialToolResin");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.InputQty).HasColumnName("inputQty");

                entity.Property(e => e.Lotno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialCategName).HasMaxLength(30);

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialLotNoSuffix)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialName).HasMaxLength(30);

                entity.Property(e => e.MaterialSpec).HasMaxLength(30);

                entity.Property(e => e.OpeGroupName)
                    .HasMaxLength(50)
                    .HasColumnName("OPeGroupName");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<ZzMcPowerLine>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_mc_power_line");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZzMcToSeries>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zz_mc_to_series");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);
            });

            modelBuilder.Entity<ZzProcessFlowSti>(entity =>
            {
                entity.HasKey(e => new { e.FlowId, e.ProcessSeqNo });

                entity.ToTable("zzProcessFlow_STI");

                entity.Property(e => e.FlowId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FlowID")
                    .IsFixedLength();

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefectCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.EndCarrierCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.EndCarrierSet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.QtyCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.SplitLot)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierCheck)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.StartCarrierSet)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.SurplusSucceed)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UpdateCarrierEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((1))")
                    .IsFixedLength();

                entity.Property(e => e.UpdateMaterialEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.UpdateToolEnd)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))")
                    .IsFixedLength();

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WipcontrolEnd).HasColumnName("WIPControlEnd");
            });

            modelBuilder.Entity<ZzProcessPower>(entity =>
            {
                entity.HasKey(e => e.ProcessCode)
                    .HasName("PK_zProcess_Power");

                entity.ToTable("zzProcess_Power");

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode3rd)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode8th)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);
            });

            modelBuilder.Entity<ZzProductFlowTemp>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode })
                    .HasName("PK_ZProductFlow_Temp_1");

                entity.ToTable("zzProductFlow_Temp");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZzProductPlanSummaryGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzProductPlan_Summary_Group");

                entity.Property(e => e.DeliveryPlanQty).HasColumnType("numeric(38, 2)");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.MonitoringGroup).HasMaxLength(20);

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductDate).HasColumnType("date");

                entity.Property(e => e.Unit)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZzSupplementItemCateg>(entity =>
            {
                entity.HasKey(e => new { e.OperationCode, e.MachineNo, e.Ztcname, e.ItemCateg });

                entity.ToTable("zzSupplementItemCateg");

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ztcname)
                    .HasMaxLength(50)
                    .HasColumnName("ZTCName");

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.InputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZzSupplementItemCategMaking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzSupplementItemCateg_making");

                entity.Property(e => e.InputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ztcname)
                    .HasMaxLength(50)
                    .HasColumnName("ZTCName");
            });

            modelBuilder.Entity<ZzTempLot>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.ProductCode });

                entity.ToTable("zzTempLot");

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("R_ProductCode")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZzTypeGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zzTypeGroup");

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Remark).HasMaxLength(20);

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<ZzprocessFlow>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZZProcessFlow");

                entity.Property(e => e.FlowId)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("FlowID")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZzvewCreateLotCommentForFinal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzvewCreateLotCommentForFinal");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<Zzvewproductcategory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzvewproductcategory");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HFerank)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("hFERank")
                    .IsFixedLength();

                entity.Property(e => e.Hrcateg).HasColumnName("HRCateg");

                entity.Property(e => e.OperatorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pack)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PbFcateg).HasColumnName("PbFCateg");

                entity.Property(e => e.Pgcode).HasColumnName("PGCode");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RohmLine)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RohmProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Spec)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Trno)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("TRNo")
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<ZzzCheckLinegrouidIsnull>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzz_check_linegrouid_isnull");

                entity.Property(e => e.BaseTime).HasColumnType("numeric(21, 5)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LineGroupId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineGroupID")
                    .IsFixedLength();

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LotNoSuffix)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessCode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.ProductCateg)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<ZzzEmbossStock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzzEmbossStock");

                entity.Property(e => e.MaterialLotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MaterialName)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Warehouse)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ZzzMaxSeqNo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzzMaxSeqNo");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZzzProcessSuspendedBlocking>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzz_process_suspended_blocking");

                entity.Property(e => e.Blk)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("blk")
                    .IsFixedLength();

                entity.Property(e => e.Cmd)
                    .HasMaxLength(16)
                    .HasColumnName("cmd")
                    .IsFixedLength();

                entity.Property(e => e.Dbname)
                    .HasMaxLength(10)
                    .HasColumnName("dbname");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(12)
                    .HasColumnName("hostname");

                entity.Property(e => e.Loginame)
                    .HasMaxLength(12)
                    .HasColumnName("loginame");

                entity.Property(e => e.Spid).HasColumnName("spid");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("status")
                    .IsFixedLength();

                entity.Property(e => e.Waittype)
                    .HasMaxLength(2)
                    .HasColumnName("waittype")
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZzzProductRouteTrpi>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzz_ProductRoute_TRPI");

                entity.Property(e => e.ProductCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.RouteNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasMaxLength(9)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZzzSeqNoZero>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzzSeqNoZero");

                entity.Property(e => e.LotNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ZzzTypeGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzzTypeGroup");

                entity.Property(e => e.LineId)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("LineID")
                    .IsFixedLength();

                entity.Property(e => e.LineName).HasMaxLength(50);

                entity.Property(e => e.LineName2).HasMaxLength(4000);

                entity.Property(e => e.Type).HasMaxLength(20);
            });

            modelBuilder.Entity<ZzzUpdM002sForMkAnalysis>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("zzzUpd_M002S_for_MK_Analysis");

                entity.Property(e => e.AddDate).HasColumnType("datetime");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InputOption)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ItemCateg)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.MachineNo)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.OperationCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.UpdDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ztcname)
                    .HasMaxLength(50)
                    .HasColumnName("ZTCName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
