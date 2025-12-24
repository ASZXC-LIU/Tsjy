using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tsjy.Core.Enums;


    namespace Tsjy.Application.System.Dtos.ReviewDtos
    {
        /// <summary>
        /// 专家端：任务列表项 DTO
        /// </summary>
        public class ExpertTaskListDto
        {
            public long TaskId { get; set; }
            public string BatchName { get; set; } // 任务名称
            public string SchoolName { get; set; } // 受评单位名称
            public DateTime? UploadEnd { get; set; } // 截止时间
            public int ReviewedCount { get; set; } // 已评审节点数
            public int TotalCount { get; set; } // 总节点数
        }

        /// <summary>
        /// 专家提交评审的输入模型
        /// </summary>
        public class ReviewSubmissionDto
        {
            public long TaskId { get; set; }
            public long NodeId { get; set; }
            public long ScoringItemId { get; set; } // 选中的评分等级项ID
            public AuditStatus AuditStatus { get; set; } // 审核结论（通过/驳回）
            public string? RejectReason { get; set; } // 驳回理由
        }
    }

