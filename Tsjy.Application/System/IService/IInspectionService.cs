using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tsjy.Application.System.IService
{
    public interface IInspectionService
    {
        Task<(string Content, List<string> FileUrls)> GetInspectionEvidence(long taskId, long nodeId);
    }
}
