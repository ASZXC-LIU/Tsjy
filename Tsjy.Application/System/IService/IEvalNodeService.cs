using System.Collections.Generic;
using System.Threading.Tasks;
using Furion.DependencyInjection; // 引入 Furion 依赖注入接口
using Tsjy.Application.System.Dtos;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.IService
{
    public interface IEvalNodeService : IScoped
    {

        Task<List<EvalNodeTreeDto>> GetNodesAsync([Required] string category, [Required] long TreeId);

        Task<EvalNodeTreeDto> GetNodeDetailAsync([FromQuery] string category, [FromQuery] long id);

        Task<List<EvalSystemListDto>> GetSystemListAsync([Required] string category);

        Task<long> CreateTree([Required] string category, [Required] string name);
        Task<long> CreateChildNode([FromBody] CreateNodeDto input);
        Task UpdateNode([FromBody] UpdateNodeDto input);
        Task DeactivateTree([Required] string category, [Required] long treeId);
        Task ToggleTreeStatus([Required] string category, [Required] long treeId);

    }
}