using System.Diagnostics.CodeAnalysis;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.IService;
using Tsjy.Application.System.Service; // 引用 EvalNodeService
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;
using System.Threading;
namespace Tsjy.Web.Entry.Pages.Admin
{
    public partial class SystemBuilder : IDisposable
    {
        // --- 服务注入 ---
        [Inject]
        [NotNull]
        private EvalNodeService? NodeService { get; set; }

        [Inject]
        [NotNull]
        private IScoringModelService? ScoringService { get; set; }
        private readonly SemaphoreSlim _semaphore = new(1, 1);
        [Inject]
        [NotNull]
        private ToastService? Toast { get; set; }

        [Inject]
        [NotNull]
        private DialogService? DialogService { get; set; }

        [Inject]
        [NotNull]
        private SwalService? Swal { get; set; }

        // --- 页面状态 ---

        // 左侧树的数据源
        private List<TreeViewItem<EvalNodeTreeDto>> TreeItems { get; set; } = new();
        private List<EvalNodeTreeDto> AllFlatNodes { get; set; } = new();

        private long RootNodeId { get; set; }

        // 当前选中的树节点
        private TreeViewItem<EvalNodeTreeDto>? SelectedNode { get; set; }

        // 右侧表单绑定的 DTO
        private CreateNodeDto CurrentEditModel { get; set; } = new();
        private long CurrentNodeId { get; set; } // 新增：用于存储当前选中节点的ID (编辑目标)
      
        // 评分模板下拉框选项
        private List<SelectedItem> ScoringModelOptions { get; set; } = new();

        // 当前预览的评分项列表 (用于右侧表格展示)
        private List<ScoringModelItemDto> PreviewScoringItems { get; set; } = new();

        // 当前选中的模板名称
        private string CurrentScoringModelName { get; set; } = "";

        // 当前体系类型 (可扩展为下拉选择，目前默认特教)
        private string CurrentCategory { get; set; } = "special_school";

        private string CurrentMethodContent { get; set; } = "";
        [Parameter]
        public string? Category { get; set; }

        [Parameter]
        public long? TreeId { get; set; }
        /// <summary>
        /// 初始化加载
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            if (!string.IsNullOrEmpty(Category)) CurrentCategory = Category;
            if (TreeId.HasValue && TreeId.Value > 0) RootNodeId = TreeId.Value;

            await LoadScoringModelsAsync();
            if (RootNodeId > 0)
            {
                // 注意：如果 RefreshTreeAsync 内部没加锁，这里可以直接调。
                await RefreshTreeAsync();
            }
        }

        // --- 数据加载逻辑 ---
        /// <summary>
        /// 通用方法：根据 ID 加载模板详情并更新预览区
        /// </summary>
    
        private async Task LoadScoringModelsAsync()
        {
            List<ScoringModel> list = await ScoringService.GetOptions();
            ScoringModelOptions = list.Select(x => new SelectedItem(x.Id.ToString(), x.Name)).ToList();
        }


        // 递归构建树
        private List<TreeViewItem<EvalNodeTreeDto>> BuildTree(List<EvalNodeTreeDto> allNodes, long? parentId)
        {
            var children = allNodes.Where(x => x.ParentId == parentId).OrderBy(x => x.OrderIndex).ToList();
            var treeList = new List<TreeViewItem<EvalNodeTreeDto>>();

            foreach (var node in children)
            {
                // 不显示 Method 类型的节点在树上，因为它是 Reference 的一部分
                if (node.Type == EvalNodeType.Method) continue;

                var item = new TreeViewItem<EvalNodeTreeDto>(node)
                {
                    Text = node.Code == "0" ? node.Name : $"{node.Code} {node.Name}",
                    Value = node,
                    IsExpand = true
                };
                item.Items = BuildTree(allNodes, node.Id);
                treeList.Add(item);
            }
            return treeList;
        }

        // --- 交互事件 ---

        /// <summary>
        /// 点击树节点
        /// </summary>
        private async Task OnTreeItemClick(TreeViewItem<EvalNodeTreeDto> item)
        {
            // 尝试获取锁，如果获取不到（有其他操作在运行），则等待
            await _semaphore.WaitAsync();
            try
            {
                SelectedNode = item;
                CurrentNodeId = item.Value.Id;

                // 1. 获取详情
                var detail = await NodeService.GetNodeDetailAsync(CurrentCategory, CurrentNodeId);

                // 2. 填充表单
                CurrentEditModel = new CreateNodeDto
                {
                    Name = detail.Name,
                    Code = detail.Code,
                    MaxScore = detail.MaxScore,
                    OrderIndex = detail.OrderIndex,
                    ScoringTemplateId = detail.ScoringTemplateId,
                    ParentId = detail.ParentId ?? 0,
                    Category = CurrentCategory,
                    Type = detail.Type
                };

                // 3. 处理 Reference 类型的 Method 字段
                CurrentMethodContent = "";
                if (detail.Type == EvalNodeType.Reference)
                {
                    var methodNode = AllFlatNodes.FirstOrDefault(x => x.ParentId == detail.Id && x.Type == EvalNodeType.Method);
                    if (methodNode != null) CurrentMethodContent = methodNode.Name;
                }

                // 4. 加载模板预览
                if (CurrentEditModel.ScoringTemplateId > 0)
                {
                    // 直接调用 Service 也可以，或者调用 LoadPreviewAsync
                    // 因为 LoadPreviewAsync 内部没加锁，这里可以直接调
                    await LoadPreviewAsync(CurrentEditModel.ScoringTemplateId.Value);
                }
                else
                {
                    PreviewScoringItems.Clear();
                    CurrentScoringModelName = "";
                }

                StateHasChanged();
            }
            finally
            {
                _semaphore.Release();
            }

        }

        private async Task LoadPreviewAsync(long modelId)
        {
            if (modelId <= 0)
            {
                PreviewScoringItems.Clear();
                CurrentScoringModelName = "";
                StateHasChanged();
                return;
            }

            // 这里是被其他加锁方法调用的，或者单独调用的。
            // 建议：如果此方法总是被 click 等事件直接调用，则加锁。
            // 但如果它被已经加锁的方法（如 OnTreeItemClick）调用，再次加锁会导致死锁（SemaphoreSlim 默认不可重入）。
            // ★ 策略：我们在顶层事件入口（OnTreeItemClick, OnScoringModelChanged）加锁，
            // 内部私有方法不加锁，或者使用 CheckWait。

            // 为了安全起见，我们假设 LoadPreviewAsync 可能被独立调用（如 OnScoringModelChanged），
            // 因此我们在各个事件入口处加锁最稳妥。

            try
            {
                var detail = await ScoringService.GetDetail(modelId);
                if (CurrentEditModel.ScoringTemplateId == modelId)
                {
                    PreviewScoringItems = detail.Items;
                    CurrentScoringModelName = detail.Name;
                    StateHasChanged();
                }
            }
            catch (Exception ex)
            {
                await Toast.Error("加载模板失败", ex.Message);
                PreviewScoringItems.Clear();
            }
        }
        private async Task OnBeginCreateChild()
        {
            // 加锁
            await _semaphore.WaitAsync();
            try
            {
                if (SelectedNode == null) return;
                // ... 逻辑 ...
                CurrentMethodContent = "";
                var NewEditModel = new CreateNodeDto
                {
                    Category = CurrentCategory,
                    ParentId = SelectedNode.Value.Id,
                    OrderIndex = (SelectedNode.Items.Count + 1) * 10,
                    Code = SelectedNode.Value.Code == "0" ? "1" : $"{SelectedNode.Value.Code}."
                };

                await NodeService.CreateChildNode(NewEditModel);
                await RefreshTreeAsync();

                PreviewScoringItems.Clear();
                CurrentScoringModelName = "";
            }
            finally
            {
                _semaphore.Release();
            }
        }

        /// <summary>
        /// 下拉框选择模板变动时 -> 触发预览
        /// </summary>
        private async Task OnScoringModelChanged(SelectedItem item)
        {
            // 同样加锁，防止与 OnTreeItemClick 冲突
            await _semaphore.WaitAsync();
            try
            {
                if (string.IsNullOrEmpty(item.Value)) return;
                if (long.TryParse(item.Value, out long modelId))
                {
                    CurrentEditModel.ScoringTemplateId = modelId;
                    await LoadPreviewAsync(modelId);
                }
                else
                {
                    PreviewScoringItems.Clear();
                    CurrentScoringModelName = "";
                }
            }
            finally
            {
                _semaphore.Release();
            }
        }

        // --- 增删改查操作 ---

        /// <summary>
        /// 1. 新建根节点 (体系)
        /// </summary>
        private async Task OnCreateRoot()
        {
            var op = new SwalOption()
            {
                // ...
                OnConfirmAsync = async () =>
                {
                    // 在回调内部加锁
                    await _semaphore.WaitAsync();
                    try
                    {
                        RootNodeId = await NodeService.CreateTree(CurrentCategory, $"{DateTime.Now.Year}年评价体系");
                        await Toast.Success("创建成功");
                        await RefreshTreeAsync();
                    }
                    finally
                    {
                        _semaphore.Release();
                    }
                }
            };
            await Swal.Show(op);
        }

        /// <summary>
        /// 2. 保存子节点 (表单提交)
        /// </summary>
        private async Task OnSaveNode(EditContext context)
        {
            // 保存操作也涉及 DB，需要加锁
            await _semaphore.WaitAsync();
            try
            {
                if (SelectedNode == null) return;

                // ... 更新逻辑 ...
                var updateDto = new UpdateNodeDto
                {
                    Id = CurrentNodeId,
                    Category = CurrentCategory,
                    Name = CurrentEditModel.Name,
                    Code = CurrentEditModel.Code,
                    MaxScore = CurrentEditModel.MaxScore,
                    ScoringTemplateId = CurrentEditModel.ScoringTemplateId,
                    OrderIndex = CurrentEditModel.OrderIndex
                };
                await NodeService.UpdateNode(updateDto);

                // ... Method 逻辑 ...
                if (SelectedNode.Value.Type == EvalNodeType.Reference)
                {
                    var methodNode = AllFlatNodes.FirstOrDefault(x => x.ParentId == CurrentNodeId && x.Type == EvalNodeType.Method);
                    if (methodNode != null)
                    {
                        await NodeService.UpdateNode(new UpdateNodeDto
                        {
                            Id = methodNode.Id,
                            Category = CurrentCategory,
                            Name = CurrentMethodContent,
                            Code = methodNode.Code,
                            OrderIndex = 0
                        });
                    }
                    else if (!string.IsNullOrWhiteSpace(CurrentMethodContent))
                    {
                        await NodeService.CreateChildNode(new CreateNodeDto
                        {
                            Category = CurrentCategory,
                            ParentId = CurrentNodeId,
                            Name = CurrentMethodContent,
                            Type = EvalNodeType.Method,
                            Code = "",
                            OrderIndex = 0
                        });
                    }
                }

                await Toast.Success("更新成功");

                // 刷新树
                await RefreshTreeAsync();

                // 重置
                CurrentEditModel = new CreateNodeDto();
                SelectedNode = null;
            }
            catch (Exception ex)
            {
                await Toast.Error("保存失败", ex.Message);
            }
            finally
            {
                _semaphore.Release();
            }
        }

        public void Dispose()
        {
            _semaphore?.Dispose();
            // 如果有订阅事件，也在此处取消订阅
            GC.SuppressFinalize(this);
        }

        // 获取祖先节点链 (用于上下文显示)
        private List<EvalNodeTreeDto> GetAncestors(long? parentId)
        {
            var list = new List<EvalNodeTreeDto>();
            long? currentId = parentId;
            while (currentId != null && currentId != 0)
            {
                var node = AllFlatNodes.FirstOrDefault(x => x.Id == currentId);
                if (node == null) break;
                list.Insert(0, node); // 插入到开头
                currentId = node.ParentId;
            }
            return list;
        }

        // 获取某个 Reference 节点的评估方法内容 (用于 Points 上下文显示)
        private string GetMethodContent(long referenceNodeId)
        {
            var methodNode = AllFlatNodes.FirstOrDefault(x => x.ParentId == referenceNodeId && x.Type == EvalNodeType.Method);
            return methodNode?.Name ?? "暂无评估方法";
        }

        /// <summary>
        /// 3. 删除节点
        /// </summary>
        private async Task OnDeleteNode()
        {
            if (SelectedNode == null) return;

            // 暂时未实现 Service 的 Delete 方法，这里仅做 UI 演示
            // 实际应调用 await NodeService.DeleteNode(SelectedNode.Value.Id);
            await Toast.Warning("演示模式", "删除接口待后端实现");
        }

        /// <summary>
        /// 4. 弹窗新建评分模板
        /// </summary>
        private async Task OnCreateScoringModel()
        {
            await DialogService.Show(new DialogOption
            {
                Title = "管理评分模板",
                BodyTemplate = builder =>
                {
                    builder.OpenComponent<ScoringModels>(0);
                    builder.CloseComponent();
                },
                OnCloseAsync = async () =>
                {
                    await LoadScoringModelsAsync();
                    StateHasChanged();
                }
            });
        }

   
        private async Task RefreshTreeAsync()
        {
            // 这是私有辅助方法，通常被 OnInitialized 或 OnSaveNode 调用。
            // 这些调用方应该负责处理并发，但为了保险，如果 RefreshTreeAsync 被多处调用，
            // 最好确保它执行时也是独占的，或者我们约定：所有 Public/Event Handler 方法必须加锁。

            // 让我们在调用方加锁，或者在这里加锁。
            // 考虑到 RefreshTreeAsync 操作较重，这里加锁较好。
            // *注意*：必须确保不会发生递归加锁（即 A方法加锁 -> 调用B方法 -> B方法也加锁）。
            // 目前 RefreshTreeAsync 没有被其他已加锁的方法调用（OnSaveNode 可能会调用）。
            // 如果 OnSaveNode 加了锁，这里就不能加。

            // 为了简化，我们采取【事件入口加锁】策略。
            // 下面的 RefreshTreeAsync 保持原样，只负责逻辑。

            var nodes = await NodeService.GetNodesAsync(CurrentCategory, RootNodeId);
            AllFlatNodes = nodes; // 更新缓存
            TreeItems = BuildTree(nodes, null);
            StateHasChanged();
        }

    }
}