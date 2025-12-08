using System.Collections.Generic;
using System.Threading.Tasks;
using Tsjy.Application.System.Dtos;
using Tsjy.Core.Entities;

namespace Tsjy.Application.System.IService
{
    /// <summary>
    /// 评分模板服务接口
    /// </summary>
    public interface IScoringModelService
    {
        /// <summary>
        /// 获取所有模板列表
        /// </summary>
        Task<List<ScoringModel>> GetList();

        /// <summary>
        /// 获取下拉框选项
        /// </summary>
        Task<List<ScoringModel>> GetOptions();

        /// <summary>
        /// 获取单个模板详情
        /// </summary>
        Task<ScoringModelDto> GetDetail(long id);

        /// <summary>
        /// 保存模板
        /// </summary>
        Task<long> Save(ScoringModelDto input);

        /// <summary>
        /// 删除模板
        /// </summary>
        Task Delete(long id);
    }
}