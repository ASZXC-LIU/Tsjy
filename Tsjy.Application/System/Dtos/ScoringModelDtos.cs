using System.ComponentModel.DataAnnotations;

namespace Tsjy.Application.System.Dtos
{
    /// <summary>
    /// 评分模板表单 DTO (用于新增和编辑)
    /// </summary>
    public class ScoringModelDto
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "模板名称不能为空")]
        public string Name { get; set; }

        /// <summary>
        /// 评分项列表 (前端表格数据)
        /// </summary>
        [Required]
        [MinLength(1, ErrorMessage = "请至少添加一个评分等级")]
        public List<ScoringModelItemDto> Items { get; set; } = new();
    }

    /// <summary>
    /// 评分项明细 DTO
    /// </summary>
    public class ScoringModelItemDto
    {
        public long Id { get; set; }

        // 前端不需要传 LevelCode (A/B/C)，后端会自动生成
        public string LevelCode { get; set; } 

        [Required(ErrorMessage = "系数不能为空")]
        [Range(0, 1.0, ErrorMessage = "系数必须在 0 到 1 之间")]
        public decimal Ratio { get; set; }

        [Required(ErrorMessage = "描述不能为空")]
        public string Description { get; set; }
    }
}