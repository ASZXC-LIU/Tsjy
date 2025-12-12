using System.Diagnostics.CodeAnalysis;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.IService;
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
        private IEvalNodeService? EvalNodeService { get; set; }

        [Inject]
        [NotNull]
        private IScoringModelService? ScoringService { get; set; }

        // 信号量，用于控制并发访问 DbContext
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
        private List<TreeViewItem<EvalNodeTreeDto>> TreeItems { get; set; } = new();
        private List<EvalNodeTreeDto> AllFlatNodes { get; set; } = new();
        private long RootNodeId { get; set; }
        private TreeViewItem<EvalNodeTreeDto>? SelectedNode { get; set; }
        private CreateNodeDto CurrentEditModel { get; set; } = new();
        private long CurrentNodeId { get; set; }
        private List<SelectedItem> ScoringModelOptions { get; set; } = new();
        private List<ScoringModelItemDto> PreviewScoringItems { get; set; } = new();
        private string CurrentScoringModelName { get; set; } = "";
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

            // ★★★ 修改 1: 为初始化逻辑加锁，防止与后续操作冲突 ★★★
            await _semaphore.WaitAsync();
            try
            {
                await LoadScoringModelsAsync();
                if (RootNodeId > 0)
                {
                    // RefreshTreeAsync 内部调用数据库查询，必须受保护
                    await RefreshTreeAsync();
                }
            }
            finally
            {
                _semaphore.Release();
            }
        }

        // --- 数据加载逻辑 ---
        private async Task LoadScoringModelsAsync()
        {
            List<ScoringModel> list = await ScoringService.GetOptions();
            ScoringModelOptions = list.Select(x => new SelectedItem(x.Id.ToString(), x.Name)).ToList();
        }

        private List<TreeViewItem<EvalNodeTreeDto>> BuildTree(List<EvalNodeTreeDto> allNodes, long? parentId)
        {
            var children = allNodes.Where(x => x.ParentId == parentId).OrderBy(x => x.OrderIndex).ToList();
            var treeList = new List<TreeViewItem<EvalNodeTreeDto>>();

            foreach (var node in children)
            {
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

        private async Task OnTreeItemClick(TreeViewItem<EvalNodeTreeDto> item)
        {
            // 加锁
            await _semaphore.WaitAsync();
            try
            {
                SelectedNode = item;
                CurrentNodeId = item.Value.Id;

                var detail = await EvalNodeService.GetNodeDetailAsync(CurrentCategory, CurrentNodeId);

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

                CurrentMethodContent = "";
                if (detail.Type == EvalNodeType.Reference)
                {
                    var methodNode = AllFlatNodes.FirstOrDefault(x => x.ParentId == detail.Id && x.Type == EvalNodeType.Method);
                    if (methodNode != null) CurrentMethodContent = methodNode.Name;
                }

                if (CurrentEditModel.ScoringTemplateId > 0)
                {
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
            await _semaphore.WaitAsync();
            try
            {
                if (SelectedNode == null) return;

                CurrentMethodContent = "";
                var NewEditModel = new CreateNodeDto
                {
                    Category = CurrentCategory,
                    ParentId = SelectedNode.Value.Id,
                    OrderIndex = (SelectedNode.Items.Count + 1) * 10,
                    Code = SelectedNode.Value.Code == "0" ? "1" : $"{SelectedNode.Value.Code}."
                };

                await EvalNodeService.CreateChildNode(NewEditModel);
                await RefreshTreeAsync();

                PreviewScoringItems.Clear();
                CurrentScoringModelName = "";
            }
            finally
            {
                _semaphore.Release();
            }
        }

        private async Task OnScoringModelChanged(SelectedItem item)
        {
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
                Category = SwalCategory.Question,
                Title = "新建体系",
                Content = $"确定要创建一个新的空白体系吗？",
                IsConfirm = true,
                // ★★★ 修改 2: 在回调中加锁，防止并发写入 ★★★
                OnConfirmAsync = async () =>
                {
                    await _semaphore.WaitAsync(); // 获取锁
                    try
                    {
                        // 调用 CreateTree (这是写入操作，必须保护)
                        RootNodeId = await EvalNodeService.CreateTree(CurrentCategory, $"{DateTime.Now.Year}年新评价体系");

                        await RefreshTreeAsync();
                        await Toast.Success("创建成功");
                    }
                    catch (Exception ex)
                    {
                        await Toast.Error("创建失败", ex.Message);
                    }
                    finally
                    {
                        _semaphore.Release(); // 释放锁
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
            await _semaphore.WaitAsync();
            try
            {
                if (SelectedNode == null) return;

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
                await EvalNodeService.UpdateNode(updateDto);

                if (SelectedNode.Value.Type == EvalNodeType.Reference)
                {
                    var methodNode = AllFlatNodes.FirstOrDefault(x => x.ParentId == CurrentNodeId && x.Type == EvalNodeType.Method);
                    if (methodNode != null)
                    {
                        await EvalNodeService.UpdateNode(new UpdateNodeDto
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
                        await EvalNodeService.CreateChildNode(new CreateNodeDto
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
                await RefreshTreeAsync();

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
            GC.SuppressFinalize(this);
        }

        private List<EvalNodeTreeDto> GetAncestors(long? parentId)
        {
            var list = new List<EvalNodeTreeDto>();
            long? currentId = parentId;
            while (currentId != null && currentId != 0)
            {
                var node = AllFlatNodes.FirstOrDefault(x => x.Id == currentId);
                if (node == null) break;
                list.Insert(0, node);
                currentId = node.ParentId;
            }
            return list;
        }

        private string GetMethodContent(long referenceNodeId)
        {
            var methodNode = AllFlatNodes.FirstOrDefault(x => x.ParentId == referenceNodeId && x.Type == EvalNodeType.Method);
            return methodNode?.Name ?? "暂无评估方法";
        }

        private async Task OnDeleteNode()
        {
            if (SelectedNode == null) return;
            await Toast.Warning("演示模式", "删除接口待后端实现");
        }

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
                    // 此处是弹窗关闭后的回调，如果涉及 DB 也建议加锁
                    // 但 LoadScoringModelsAsync 是读操作，且与树操作表不同，风险较小
                    // 为了一致性，可以加上
                    await _semaphore.WaitAsync();
                    try
                    {
                        await LoadScoringModelsAsync();
                        StateHasChanged();
                    }
                    finally
                    {
                        _semaphore.Release();
                    }
                }
            });
        }

        private async Task RefreshTreeAsync()
        {
            // 注意：此方法必须在已获取锁的上下文中调用
            var nodes = await EvalNodeService.GetNodesAsync(CurrentCategory, RootNodeId);
            AllFlatNodes = nodes;
            TreeItems = BuildTree(nodes, null);
            StateHasChanged();
        }
    }
}