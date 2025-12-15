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
    public class EvalNodeService : IDynamicApiController, IScoped, IEvalNodeService
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

        public async Task<List<EvalNodeTreeDto>> GetFlatListAsync(string category, long treeId)
        {
            // 根据 category 决定查哪个表，并映射为 EvalNodeTreeDto
            // 这里为了简单，假设 EvalNodeTreeDto 有 Id, Name, Code, Type 属性
            if (category == "special_school")
            {
                return await _speRepo.Where(x => x.TreeId == treeId && !x.IsDeleted)
                                     .OrderBy(x => x.Code)
                                     .ProjectToType<EvalNodeTreeDto>()
                                     .ToListAsync();
            }
            else if (category == "inclusive_school")
            {
                return await _incRepo.Where(x => x.TreeId == treeId && !x.IsDeleted)
                                     .OrderBy(x => x.Code)
                                     .ProjectToType<EvalNodeTreeDto>()
                                     .ToListAsync();
            }
            else if (category == "education_bureau")
            {
                return await _eduRepo.Where(x => x.TreeId == treeId && !x.IsDeleted)
                                     .OrderBy(x => x.Code)
                                     .ProjectToType<EvalNodeTreeDto>()
                                     .ToListAsync();
            }
            return new List<EvalNodeTreeDto>();
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
        /// <summary>
        /// 4. 停用（软删除）整个评价体系及其所有子节点
        /// </summary>
        [HttpPost("api/eval/deactivate-tree")]
        public async Task DeactivateTree([Required] string category, [Required] long treeId)
        {
            switch (category?.ToLower())
            {
                case "special_school":
                    await DeactivateTreeInternal(_speRepo, treeId);
                    break;
                case "inclusive_school":
                    await DeactivateTreeInternal(_incRepo, treeId);
                    break;
                case "education_bureau":
                    await DeactivateTreeInternal(_eduRepo, treeId);
                    break;
                default:
                    throw new ArgumentException($"无效的评价体系类型: {category}");
            }
        }


        /// <summary>
        /// 5. 删除节点（软删除，并级联删除子节点）
        /// </summary>
        [HttpPost("api/eval/delete-node")]
        public async Task DeleteNode([Required] string category, [Required] long nodeId)
        {
            switch (category?.ToLower())
            {
                case "special_school":
                    await DeleteNodeInternal(_speRepo, nodeId);
                    break;
                case "inclusive_school":
                    await DeleteNodeInternal(_incRepo, nodeId);
                    break;
                case "education_bureau":
                    await DeleteNodeInternal(_eduRepo, nodeId);
                    break;
                default:
                    throw new ArgumentException($"无效的评价体系类型: {category}");
            }
        }
        private async Task<List<EvalSystemListDto>> GetSystemListInternal<T>(IRepository<T> repo, string category)
    where T : class, IEntity, IEvalNode, new()
        {
            // 查找根节点 (ParentId 为空 或者 Type 为 System)
            // 根据你的CreateTree逻辑，根节点ParentId为null [cite: 5]
            var roots = await repo.Where(x => x.ParentId == null)
                                  .OrderByDescending(x => x.CreatedAt)
                                  .ToListAsync();
            Console.Write(roots);
            return roots.Select(x => new EvalSystemListDto
            {
                Id = x.Id,
                Name = x.Name,
                Category = category,
                CreatedAt = x.CreatedAt,
                IsDeleted = x.IsDeleted
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




        /// <summary>
        /// 通用的递归停用逻辑
        /// </summary>
        private async Task DeactivateTreeInternal<T>(IRepository<T> repo, long treeId)
            where T : class, IEntity, IEvalNode, new()
        {
            // 1. 查找该体系下的所有节点 (包括根节点)
            // 注意：这里我们直接根据 TreeId 查找所有相关节点，这比递归查询更高效
            var allNodes = await repo.Where(x => x.TreeId == treeId && !x.IsDeleted).ToListAsync();

            if (!allNodes.Any())
            {
                // 如果找不到任何节点，可能已经被删除了，直接返回或抛异常
                return;
            }

            // 2. 批量更新 IsDeleted 状态
            foreach (var node in allNodes)
            {
                node.IsDeleted = true;
                // node.UpdatedAt = DateTime.Now; // 如果实体有 UpdatedAt
            }

            // 3. 批量保存
            await repo.UpdateNowAsync(allNodes);
        }


        [HttpPost("api/eval/toggle-status")]
        public async Task ToggleTreeStatus([Required] string category, [Required] long treeId)
        {
            // 直接使用具体的 Repo 进行操作，避免泛型约束冲突
            switch (category?.ToLower())
            {
                case "special_school":
                    var rootSpe = await _speRepo.FirstOrDefaultAsync(x => x.Id == treeId);
                    if (rootSpe != null)
                    {
                        rootSpe.IsDeleted = !rootSpe.IsDeleted;
                        await _speRepo.UpdateNowAsync(rootSpe);
                    }
                    break;

                case "inclusive_school":
                    var rootInc = await _incRepo.FirstOrDefaultAsync(x => x.Id == treeId);
                    if (rootInc != null)
                    {
                        rootInc.IsDeleted = !rootInc.IsDeleted;
                        await _incRepo.UpdateNowAsync(rootInc);
                    }
                    break;

                case "education_bureau":
                    var rootEdu = await _eduRepo.FirstOrDefaultAsync(x => x.Id == treeId);
                    if (rootEdu != null)
                    {
                        rootEdu.IsDeleted = !rootEdu.IsDeleted;
                        await _eduRepo.UpdateNowAsync(rootEdu);
                    }
                    break;

                default:
                    throw new ArgumentException($"无效的评价体系类型: {category}");
            }
        }


        /// <summary>
        /// 通用的级联软删除逻辑
        /// </summary>
        private async Task DeleteNodeInternal<T>(IRepository<T> repo, long nodeId)
            where T : class, IEntity, IEvalNode, new()
        {
            // 1. 获取目标节点
            var targetNode = await repo.FirstOrDefaultAsync(x => x.Id == nodeId);
            if (targetNode == null) return;

            // 2. 获取该体系下的所有有效节点（用于计算后代和重排）
            var allTreeNodes = await repo.Where(x => x.TreeId == targetNode.TreeId && !x.IsDeleted)
                                         .ToListAsync();

            // 3. 级联标记删除
            // 找到所有需要删除的ID（自己 + 所有后代）
            var deleteIds = new List<long> { nodeId };
            GetDescendants(allTreeNodes, nodeId, deleteIds);

            // 在内存中标记删除
            var nodesToDelete = allTreeNodes.Where(x => deleteIds.Contains(x.Id)).ToList();
            foreach (var node in nodesToDelete)
            {
                node.IsDeleted = true;
            }

            // 先保存删除状态，确保数据一致性
            await repo.UpdateNowAsync(nodesToDelete);

            // 4. ★★★ 核心步骤：重排剩余节点的序号 ★★★
            // 过滤出剩余的有效节点
            var remainingNodes = allTreeNodes.Where(x => !deleteIds.Contains(x.Id)).ToList();

            // 从根节点开始递归重算 Code
            // ParentId 为 null 的是根节点
            bool anyChanged = ReorganizeRecursively(remainingNodes, null, "");

            if (anyChanged)
            {
                await repo.UpdateNowAsync(remainingNodes);
            }
        }
        /// <summary>
        /// 递归重排序号
        /// </summary>
        /// <param name="allNodes">所有有效节点池</param>
        /// <param name="parentId">当前父级ID</param>
        /// <param name="parentCodePrefix">父级Code前缀（如 "1.2"）</param>
        /// <returns>是否有数据变动</returns>
        private bool ReorganizeRecursively<T>(List<T> allNodes, long? parentId, string parentCodePrefix)
            where T : IEvalNode
        {
            // 找到当前层级的子节点，并按 OrderIndex 排序保证顺序不乱
            var children = allNodes.Where(x => x.ParentId == parentId)
                                   .OrderBy(x => x.OrderIndex)
                                   .ToList();

            bool changed = false;

            for (int i = 0; i < children.Count; i++)
            {
                var child = children[i];

                // 计算新序号：
                // 如果是根节点，就是 "0"...
                // 如果是子节点，就是 "ParentCode.1", "ParentCode.2"...
                string rank = (i ).ToString();
                string newCode = string.IsNullOrEmpty(parentCodePrefix) ? rank : $"{parentCodePrefix}.{rank}";

                // 检查是否需要更新 Code
                if (child.Code != newCode)
                {
                    child.Code = newCode;
                    changed = true;
                }

                // 可选：顺便重置 OrderIndex 为整齐的 10, 20, 30... 防止多次增删后中间有空隙
                int newOrder = (i + 1) * 10;
                if (child.OrderIndex != newOrder)
                {
                    child.OrderIndex = newOrder;
                    changed = true;
                }

                // 递归处理下一级（传入当前的 newCode 作为前缀）
                if (ReorganizeRecursively(allNodes, child.Id, newCode))
                {
                    changed = true;
                }
            }

            return changed;
        }
        // 辅助方法：递归查找子孙节点 ID
        private void GetDescendants<T>(List<T> allNodes, long parentId, List<long> results)
            where T : IEvalNode
        {
            var children = allNodes.Where(x => x.ParentId == parentId).ToList();
            foreach (var child in children)
            {
                results.Add(child.Id);
                // 递归
                GetDescendants(allNodes, child.Id, results);
            }
        }




        #endregion





    }
}

