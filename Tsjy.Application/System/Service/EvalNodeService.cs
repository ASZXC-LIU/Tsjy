using System.Security.Claims;
using Furion.DatabaseAccessor;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;
using Tsjy.Core.MyHelper;

namespace Tsjy.Application.System.Service
{
    public class EvalNodeService : IDynamicApiController, IScoped
    {
        private readonly IRepository<SpeEvalNode> _speRepo;
        private readonly IRepository<IncEvalNode> _incRepo;
        private readonly IRepository<EduEvalNode> _eduRepo;

        // 构造函数注入
        public EvalNodeService(
            IRepository<SpeEvalNode> speRepo,
            IRepository<IncEvalNode> incRepo,
            IRepository<EduEvalNode> eduRepo)
        {
            _speRepo = speRepo;
            _incRepo = incRepo;
            _eduRepo = eduRepo;
        }



        #region 查询接口

        /// <summary>
        /// 获取指定体系下的所有节点（扁平列表，前端转树）
        /// </summary>
        [HttpGet("api/eval/nodes")]
        public async Task<List<EvalNodeTreeDto>> GetNodesAsync([Required] string category, [Required] long TreeId)
        {
            return category?.ToLower() switch
            {
                "special_school" => await GetNodesInternal(_speRepo, TreeId),
                "inclusive_school" => await GetNodesInternal(_incRepo, TreeId),
                "education_bureau" => await GetNodesInternal(_eduRepo, TreeId),
                _ => throw new ArgumentException($"无效的评价体系类型: {category}")
            };
        }

        [HttpGet("api/eval/node-detail")]
        public async Task<EvalNodeTreeDto> GetNodeDetailAsync([FromQuery] string category, [FromQuery] long id)
        {
            return category?.ToLower() switch
            {
                "special_school" => await GetNodeDetailInternal(_speRepo, id),
                "inclusive_school" => await GetNodeDetailInternal(_incRepo, id),
                "education_bureau" => await GetNodeDetailInternal(_eduRepo, id),
                _ => throw new ArgumentException($"无效的评价体系类型: {category}")
            };
        }
        /// <summary>
        /// 获取指定类型的评价体系列表（查找所有的根节点）
        /// </summary>
        [HttpGet("api/eval/systems")]
        public async Task<List<EvalSystemListDto>> GetSystemListAsync([Required] string category)
        {
            return category?.ToLower() switch
            {
                "special_school" => await GetSystemListInternal(_speRepo, category),
                "inclusive_school" => await GetSystemListInternal(_incRepo, category),
                "education_bureau" => await GetSystemListInternal(_eduRepo, category),
                _ => throw new ArgumentException($"无效的评价体系类型: {category}")
            };
        }
        #endregion
        #region 核心业务接口

        /// <summary>
        /// 1. 新建评价体系（建立树根）
        /// </summary>
        /// <param name="category">类型：special_school / inclusive_school / education_bureau</param>
        /// <param name="name">体系名称（如：2025河北特教考评）</param>
        [HttpPost("api/eval/create-tree")]
        public async Task<long> CreateTree([Required] string category, [Required] string name)
        {
            return category?.ToLower() switch
            {
                "special_school" => await CreateTreeInternal(_speRepo, name),
                "inclusive_school" => await CreateTreeInternal(_incRepo, name),
                "education_bureau" => await CreateTreeInternal(_eduRepo, name),
                _ => throw new ArgumentException($"无效的评价体系类型: {category}")
            };
        }


        /// <summary>
        /// 2. 新建子节点（建立枝叶）
        /// </summary>
        [HttpPost("api/eval/create-node")]
        public async Task<long> CreateChildNode([FromBody] CreateNodeDto input)
        {
            return input.Category?.ToLower() switch
            {
                "special_school" => await CreateChildNodeInternal(_speRepo, input),
                "inclusive_school" => await CreateChildNodeInternal(_incRepo, input),
                "education_bureau" => await CreateChildNodeInternal(_eduRepo, input),
                _ => throw new ArgumentException($"无效的评价体系类型: {input.Category}")
            };
        }
        /// <summary>
        /// 3. 更新节点基本信息
        /// </summary>
        [HttpPost("api/eval/update-node")]
        public async Task UpdateNode([FromBody] UpdateNodeDto input)
        {
            // 根据 Category 路由到对应的私有方法
            switch (input.Category?.ToLower())
            {
                case "special_school":
                    await UpdateNodeInternal(_speRepo, input);
                    break;
                case "inclusive_school":
                    await UpdateNodeInternal(_incRepo, input);
                    break;
                case "education_bureau":
                    await UpdateNodeInternal(_eduRepo, input);
                    break;
                default:
                    throw new ArgumentException($"无效的评价体系类型: {input.Category}");
            }
        }


        private async Task<List<EvalSystemListDto>> GetSystemListInternal<T>(IRepository<T> repo, string category)
    where T : class, IEntity, IEvalNode, new()
        {
            // 查找根节点 (ParentId 为空 或者 Type 为 System)
           // 根据你的CreateTree逻辑，根节点ParentId为null [cite: 5]
            var roots = await repo.Where(x => x.ParentId == null && !x.IsDeleted)
                                  .OrderByDescending(x => x.CreatedAt)
                                  .ToListAsync();
            Console.Write(roots);
            return roots.Select(x => new EvalSystemListDto
            {
                Id = x.Id,
                Name = x.Name,
                Category = category,
                CreatedAt = x.CreatedAt,
                // 如果需要统计节点数，可能需要额外的查询，这里暂时略过
            }).ToList();
        }

        #endregion

        #region 私有通用泛型方法 (核心逻辑)


        // 通用查询逻辑
        private async Task<List<EvalNodeTreeDto>> GetNodesInternal<T>(IRepository<T> repo, [Required] long TreeId)
             where T : class, IEntity, IEvalNode, new()
        {
            var list = await repo.Where(x => !x.IsDeleted && x.TreeId == TreeId)
                                 .OrderBy(x => x.OrderIndex)
                                 .ToListAsync();

            return list.Select(x => new EvalNodeTreeDto
            {
                Id = x.Id,
                ParentId = x.ParentId,
                Name = x.Name,
                Code = x.Code,
                Type = x.Type,
                MaxScore = x.MaxScore,
                OrderIndex = x.OrderIndex
            }).ToList();
        }


        /// <summary>
        /// 通用的创建树根逻辑
        /// </summary>
        /// <typeparam name="T">实体类型，必须同时实现 IEntity 和 IEvalNode</typeparam>
        private async Task<long> CreateTreeInternal<T>(IRepository<T> repo, string name)
            // ★★★ 核心修复：添加 IEntity 约束，满足 IRepository<T> 的要求 ★★★
            where T : class, IEntity, IEvalNode, new()
        {
            var rootNode = new T
            {
                ParentId = null,
                Path = "0",
                Depth = 0,
                Type = EvalNodeType.System,
                Name = name,
                Code = "0",
                ScoringTemplateId = 1, // 默认模型ID
                CreatedAt = DateTime.Now
            };

            await repo.InsertNowAsync(rootNode);

            // 更新 TreeId 为自身 ID
            rootNode.TreeId = rootNode.Id;
            await repo.UpdateNowAsync(rootNode);

            return rootNode.Id;
        }

        /// <summary>
        /// 通用的创建子节点逻辑
        /// </summary>
        /// <typeparam name="T">实体类型，必须同时实现 IEntity 和 IEvalNode</typeparam>
        // 在 CreateChildNodeInternal 方法中修改类型判断逻辑
        private async Task<long> CreateChildNodeInternal<T>(IRepository<T> repo, CreateNodeDto input)
            where T : class, IEntity, IEvalNode, new()
        {
            // 1. 查找父节点
            var parentNode = await repo.FirstOrDefaultAsync(x => x.Id == input.ParentId);
            if (parentNode == null) throw new Exception("父节点不存在");

            // 2. 计算 Path 和 Depth
            var newDepth = parentNode.Depth + 1;
            var pathPrefix = (parentNode.Path == "0" || string.IsNullOrEmpty(parentNode.Path)) ? "" : parentNode.Path + ",";
            var newPath = (parentNode.Path == "0") ? parentNode.Id.ToString() : (parentNode.Path + "," + parentNode.Id);

            // 3. 确定类型：如果前端传了明确的类型（非System默认值），则使用前端传的，否则自动推断
            // 注意：CreateNodeDto中Type默认为System(0)
            EvalNodeType newType;
            if (input.Type != EvalNodeType.System)
            {
                newType = input.Type;
            }
            else
            {
                // 原有的自动推断逻辑
                newType = newDepth switch
                {
                    1 => EvalNodeType.FirstIndicator,
                    2 => EvalNodeType.SecondIndicator,
                    3 => EvalNodeType.Reference,
                    4 => EvalNodeType.Points,
                    _ => EvalNodeType.Method
                };
            }

            // 4. 创建实体
            var newNode = new T
            {
                TreeId = parentNode.TreeId,
                ParentId = input.ParentId,
                Path = newPath,
                Depth = newDepth,
                Type = newType, // 使用新的类型逻辑
                Code = input.Code,
                Name = input.Name,
                MaxScore = input.MaxScore,
                ScoringTemplateId = input.ScoringTemplateId,
                OrderIndex = input.OrderIndex,
                CreatedAt = DateTime.Now
            };

            await repo.InsertNowAsync(newNode);
            return newNode.Id;
        }



        /// <summary>
        /// 通用的获取节点详情逻辑
        /// </summary>
        private async Task<EvalNodeTreeDto> GetNodeDetailInternal<T>(IRepository<T> repo, long id)
            where T : class, IEntity, IEvalNode, new()
        {
            // 查询节点，排除已删除的
            var node = await repo.FirstOrDefaultAsync(x => x.Id == id && !x.IsDeleted);

            if (node == null)
            {
                throw new Exception($"未找到 ID 为 {id} 的节点信息");
            }

            // 映射实体到 DTO
            return new EvalNodeTreeDto
            {
                Id = node.Id,
                ParentId = node.ParentId ?? 0,
                Name = node.Name,
                Code = node.Code,
                MaxScore = node.MaxScore,
                ScoringTemplateId = node.ScoringTemplateId,
                OrderIndex = node.OrderIndex,

                // ★★★ 在此处添加缺失的 Type 映射 ★★★
                Type = node.Type
            };
        }


        /// <summary>
        /// 通用的更新节点逻辑
        /// </summary>
        private async Task UpdateNodeInternal<T>(IRepository<T> repo, UpdateNodeDto input)
            where T : class, IEntity, IEvalNode, new()
        {
            // 1. 获取实体
            var entity = await repo.FirstOrDefaultAsync(x => x.Id == input.Id);

            if (entity == null)
            {
                throw new Exception($"未找到 ID 为 {input.Id} 的节点，无法更新。");
            }

            // 2. 更新属性
            // 注意：不更新 ParentId, Path, Depth, TreeId, Type，防止破坏树结构
            entity.Code = input.Code;
            entity.Name = input.Name;
            entity.MaxScore = input.MaxScore;
            entity.ScoringTemplateId = input.ScoringTemplateId;
            entity.OrderIndex = input.OrderIndex;

            // 记录更新时间（如果实体有 UpdatedAt 字段的话，IEvalNode 接口里可能没有，视情况而定）
            // entity.UpdatedAt = DateTime.Now; 

            // 3. 保存更改
            await repo.UpdateNowAsync(entity);
        }
        #endregion





    }
}

