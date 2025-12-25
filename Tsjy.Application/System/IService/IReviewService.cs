using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.Dtos.ReviewDtos;
using Tsjy.Application.System.Dtos.SysusersDtos;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.IService
{
    public interface IReviewService
    {
        Task<List<ExpertTaskListDto>> GetExpertTasks(string expertId);
        Task SubmitReview([FromBody] ReviewSubmissionDto input);
        Task<List<ExpertReviewNodeDto>> GetExpertReviewNodes(long taskId, string expertId);
    }
}
