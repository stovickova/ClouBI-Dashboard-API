using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashboardTestApi.Data
{
    public partial class NConnectorEntity : IEntity<int> { }
    public partial class NWorkflowEntity : IEntity<int> { }
    public partial class NWorkflowParameterEntity : IEntity<int> { }
    public partial class NWorkflowStepEntity : IEntity<int> { }
    public partial class NDefinitionEntity : IEntity<int> { }
    public partial class NInputDefinitionEntity : IEntity<int> { }
    public partial class NParameterMappingEntity : IEntity<int> { }
    public partial class ModelValueTimeFilterEntity : IEntity<int> { }
    public partial class ModelValueDimFilterEntity : IEntity<int> { }
    public partial class ModelValueIndicatorFilterEntity : IEntity<int> { }
    public partial class RoundingPrecisionEntity : IEntity<int> { }
    public partial class ValueFilterTypeEntity : IEntity<int> { }
    public partial class StepParametersValueEntity : IEntity<long> { }
    public partial class RuleTimeRowEntity : IEntity<int> { }
    public partial class FreeFieldValues2Entity : IEntity<long> { }
    public partial class RoundTypeEntity : IEntity<int> { }
    public partial class ModelDimensionalityEntity : IEntity<int> { }
    public partial class RuleDimRowEntity : IEntity<int> { }
    public partial class RuleTypeEntity : IEntity<int> { }
    public partial class RuleFreeFieldEntity : IEntity<int> { }
    public partial class RuleEntity : IEntity<int> { }
    public partial class MemberSetFactEntity : IEntity<long>{ }
    public partial class MemberSetEntity : IEntity<long> { }
    public partial class MemberSetDetailEntity : IEntity<long> { }

    public partial class FreeFieldEntity : IEntity<int> { }
    public partial class FreeFieldValueEntity : IEntity<long> { }
    public partial class MemberListFreeFieldEntity : IEntity<int> { }
    public partial class HierarchyTypeEntity : IEntity<int> { }

    public partial class WorkflowScheduleEntity : IEntity<int> { }
    public partial class ServerLogEntity : IEntity<long> { }
    public partial class ScheduleEntity : IEntity<int> { }

    public partial class ObjectiveTypeEntity : IEntity<int> { }
    public partial class ParameterEntity : IEntity<string>
    {
        public string Id => ParameterName;
    }
    public partial class UserParameterEntity : IEntity<int> { }

    public partial class DelegatedUserEntity : IEntity<int> { }
    public partial class OutputEntity : IEntity<int> { }
    public partial class OutputXmlEntity : IEntity<int> { }
    public partial class ActionEntity : IEntity<int> { }
    public partial class TaskEntity : IEntity<int> { }
    public partial class TaskValueEntity : IEntity<int> { }
    public partial class OutputConnectionEntity : IEntity<int> { }
    public partial class LicenceEntity : IEntity<int> { }
    public partial class MeetingEntity : IEntity<int> { }
    public partial class StepRunLogEntity : IEntity<int>
    {
    }

    public partial class WorkflowEntity : IEntity<int>
    {
    }

    public partial class WorkflowStepDetailEntity : IEntity<int>
    {
    }

    public partial class WorkflowStepEntity : IEntity<int>
    {
    }

    public partial class IndicatorEntity : IEntity<int>
    {
    }

    public partial class ReportEntity : IEntity<int>
    {
    }

    public partial class ReportRowEntity : IEntity<int>
    {
    }
    public partial class ReportRelationEntity : IEntity<int>
    {
    }

    public partial class ConstantValueEntity : IEntity<int>
    {
    }

    public partial class IndicatorFormulaEntity : IEntity<int>
    {
        public int Id => this.IndicatorId;
    }

    public partial class IndicatorCalculationEntity : IEntity<int>
    {
    }

    public partial class MemberListEntity : IEntity<int>
    {
    }
    public partial class MemberEntity : IEntity<int>
    {
    }

    public partial class MemberRelationEntity : IEntity<long>
    {
    }

    public partial class MemberListRelationEntity : IEntity<int>
    {
    }

    public partial class HierarchyEntity : IEntity<int>
    {
    }

    public partial class HierarchySourceEntity : IEntity<int>
    {
    }

    public partial class HierarchyLevelEntity : IEntity<int>
    {
    }

    public partial class DimensionEntity : IEntity<int>
    {
    }

    public partial class ModelEntity : IEntity<int>
    {
    }

    public partial class WorkflowStepIndicatorEntity : IEntity<int>
    {
    }

    public partial class WorkflowStepDimFilterEntity : IEntity<int>
    {
    }

    public partial class WorkflowStepTimeFilterEntity : IEntity<int>
    {
    }

    public partial class MemberLabelEntity : IEntity<int>
    {
    }

    public partial class ModelIndicatorEntity : IEntity<int>
    {
    }

    public partial class ModelIndicatorDetailLevelEntity : IEntity<int>
    {
    }

    public partial class IndicatorValueTypeEntity : IEntity<int>
    {
    }

    public partial class ModelIndicatorValueTypeEntity : IEntity<int>
    {
    }

    public partial class ModelValuesSharingEntity : IEntity<int>
    {
    }

    public partial class ModelSharingDimensionalityEntity : IEntity<int>
    {
    }

    public partial class ModelReportEntity : IEntity<int>
    {
    }

    public partial class ModelDefaultValueTypeEntity : IEntity<int>
    {
    }

    public partial class ModelIndicatorValueSourceEntity : IEntity<int>
    {
    }

    public partial class ModelIndicatorValueSourceDimLevelEntity : IEntity<int>
    {
    }

    public partial class ModelIndicatorValueSourceTimeLevelEntity : IEntity<int>
    {
    }

    public partial class TimeInputTypeEntity : IEntity<byte>
    {
    }

    public partial class ModelValueSourceEntity : IEntity<int>
    {
    }

    public partial class ModelValueSourceDimLevelEntity : IEntity<int>
    {
    }

    public partial class ModelValueSourceTimeLevelEntity : IEntity<int>
    {
    }

    public partial class FavoriteOutputEntity : IEntity<int>
    {        
    }
    public partial class WorkflowsRunEntity : IEntity<int>
    {
    }
    public partial class CreateCubeInputEntity : IEntity<int>
    {
    }
    public partial class TagEntity : IEntity<int>
    {
    }
    public partial class TagRelationEntity : IEntity<int>
    {
    }
    public partial class GroupEntity : IEntity<int> { }
    public partial class GroupGroupEntity : IEntity<int> { }
    public partial class ObjectTypeEntity : IEntity<int> { }
    public partial class ObjectTypeRelationEntity : IEntity<int> { }
    public partial class PermissionEntity : IEntity<int> { }
    public partial class PermissionObjectEntity : IEntity<int> { }
    public partial class PermissionRelationEntity : IEntity<int> { }
    public partial class PermissionRoleEntity : IEntity<int> { }
    public partial class PermissionTypeEntity : IEntity<int> { }
    public partial class RoleRoleEntity : IEntity<int> { }
    public partial class RoleEntity : IEntity<int> { }
    public partial class UserEntity : IEntity<int> { }
    public partial class UserGroupEntity : IEntity<int> { }
}
