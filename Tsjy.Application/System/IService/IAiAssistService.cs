using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsjy.Application.System.Dtos.AI;
namespace Tsjy.Application.System.IService;

public interface IAiAssistService
{
    Task<AiAssistResultDto> ExpertAssistAsync(long taskId, long nodeId, CancellationToken ct = default);
}
