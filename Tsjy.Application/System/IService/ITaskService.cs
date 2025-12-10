using System.Collections.Generic;
using System.Threading.Tasks;
using Furion.DependencyInjection; // 引入 Furion 依赖注入接口
using Tsjy.Application.System.Dtos;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.IService
{
    public interface ITaskService : ITransient
    {
        
        Task<List<SysUserDto>> GetTargetsByType(OrgType type);
        Task PublishTask([FromBody] DistributeTaskDto input);
        Task<List<SchoolTaskListDto>> GetMyTasks(long myId);
        Task<List<TaskNodeTreeDto>> GetTaskTree(long taskId);
        Task<NodeFillDetailDto> GetNodeFillDetail(long taskId, long nodeId);
        Task SubmitEvidence(NodeFillDetailDto input);




    }
}