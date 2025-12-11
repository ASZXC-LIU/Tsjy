using System.Diagnostics.CodeAnalysis;
using BootstrapBlazor.Components;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Tsjy.Application.System.Dtos;
using Tsjy.Application.System.IService;
using Tsjy.Application.System.Service; // 引用 EvalNodeService
using Tsjy.Core.Entities;

namespace Tsjy.Web.Entry.Pages.Admin
{
    public partial class SystemBuilder
    {
        // --- 服务注入 ---
        [Inject]
        [NotNull]
        private EvalNodeService? NodeService { get; set; }

        [Inject]
        [NotNull]
        private IScoringModelService? ScoringService { get; set; }

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
        [Parameter]
        public string? Category { get; set; }

        [Parameter]
        public long? TreeId { get; set; }
        /// <summary>
        /// 初始化加载
        /// </summary>
        protected override async Task OnInitializedAsync()
        {
            // 1. 处理参数逻辑
            if (!string.IsNullOrEmpty(Category))
            {
                CurrentCategory = Category;
            }

            if (TreeId.HasValue && TreeId.Value > 0)
            {
                RootNodeId = TreeId.Value;
            }
            else
            {
                // 如果没有传ID（比如直接访问 /Admin/EvalBuilder），
                // 这里可能需要逻辑去默认加载最新一个，或者提示用户去列表页
                // 目前保持逻辑：RootNodeId 为 0，页面显示"暂无数据"
            }
            await LoadScoringModelsAsync();
            if (RootNodeId > 0)
            {
                await RefreshTreeAsync();
            }
        }

        // --- 数据加载逻辑 ---
        /// <summary>
        /// 通用方法：根据 ID 加载模板详情并更新预览区
        /// </summary>
        private async Task LoadPreviewAsync(long modelId)
        {
            // 0. 如果 ID 无效，直接清空
            if (modelId <= 0)
            {
                PreviewScoringItems.Clear();
                CurrentScoringModelName = "";
                StateHasChanged();
                return;
            }

            try
            {
                // 1. 调用接口获取详情
                var detail = await ScoringService.GetDetail(modelId);

                // ★★★ 关键修复：竞态保护 ★★★
                // 请求回来后，检查当前表单选中的 ID 是否还等于刚才请求的 ID
                // 如果用户在请求期间又点选了别的，这个 ID 就不匹配了，抛弃这次结果，防止覆盖
                if (CurrentEditModel.ScoringTemplateId == modelId)
                {
                    PreviewScoringItems = detail.Items;
                    CurrentScoringModelName = detail.Name;
                    StateHasChanged();
                }
            }
            catch (Exception ex)
            {
                // 容错处理：如果模板被删除了等情况
                await Toast.Error("加载模板失败", ex.Message);
                PreviewScoringItems.Clear();
            }
        }
        private async Task LoadScoringModelsAsync()
        {
            List<ScoringModel> list = await ScoringService.GetOptions();
            ScoringModelOptions = list.Select(x => new SelectedItem(x.Id.ToString(), x.Name)).ToList();
        }

        private async Task RefreshTreeAsync()
        {
            var nodes = await NodeService.GetNodesAsync(CurrentCategory, RootNodeId);

            // 转换为树形结构
            TreeItems = BuildTree(nodes, null);
            StateHasChanged();
        }

        // 递归构建树
        private List<TreeViewItem<EvalNodeTreeDto>> BuildTree(List<EvalNodeTreeDto> allNodes, long? parentId)
        {
            var children = allNodes.Where(x => x.ParentId == parentId).OrderBy(x => x.OrderIndex).ToList();
            var treeList = new List<TreeViewItem<EvalNodeTreeDto>>();

            foreach (var node in children)
            {
                var item = new TreeViewItem<EvalNodeTreeDto>(node)
                {
                    Text = node.Code == "0" ? node.Name : $"{node.Code} {node.Name}",
                    Value = node,
                    IsExpand = true // 默认展开
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
            SelectedNode = item;
           
            CurrentNodeId = item.Value.Id; // 保存当前选中节点的 ID
            var CurrentNodeDetail = await NodeService.GetNodeDetailAsync(CurrentCategory, CurrentNodeId);
            CurrentEditModel.Name = CurrentNodeDetail.Name;
            CurrentEditModel.Code = CurrentNodeDetail.Code;
            CurrentEditModel.MaxScore = CurrentNodeDetail.MaxScore;
            CurrentEditModel.OrderIndex = CurrentNodeDetail.OrderIndex;
            CurrentEditModel.ScoringTemplateId = CurrentNodeDetail.ScoringTemplateId;
            CurrentEditModel.ParentId = SelectedNode.Value.Id;
            CurrentEditModel.Category = CurrentCategory;
            if (CurrentEditModel.ScoringTemplateId > 0)
            {
                await LoadPreviewAsync(CurrentEditModel.ScoringTemplateId.Value);
            }
            else
            {
                // 如果该节点没有关联模板，清空预览
                PreviewScoringItems.Clear();
                CurrentScoringModelName = "";
            }
            StateHasChanged();

        }


        private async Task OnBeginCreateChild()
        {
            if (SelectedNode == null) return;

          

            // 重置表单，准备添加子节点
            var NewEditModel = new CreateNodeDto
            {
                Name = "新建节点",
                Category = CurrentCategory,
                ParentId = SelectedNode.Value.Id,
                ScoringTemplateId = 0, // 重置模板
                OrderIndex = (SelectedNode.Items.Count + 1) * 10 // 自动生成默认排序
            };

            // 智能生成序号
            if (SelectedNode.Value.Code != "0")
            {
                NewEditModel.Code = $"{SelectedNode.Value.Code}.";
            }
            else
            {
                NewEditModel.Code = "1";
            }
            await NodeService.CreateChildNode(NewEditModel);
            await RefreshTreeAsync();
            // 清空预览
            PreviewScoringItems.Clear();
            CurrentScoringModelName = "";
        }

        /// <summary>
        /// 下拉框选择模板变动时 -> 触发预览
        /// </summary>
        private async Task OnScoringModelChanged(SelectedItem item)
        {
            if (string.IsNullOrEmpty(item.Value)) return;
            if (long.TryParse(item.Value, out long modelId))
            {
                CurrentEditModel.ScoringTemplateId = modelId;

                // 调用通用方法
                await LoadPreviewAsync(modelId);

            }
            else
            {
                // 如果选了空项（比如“请选择”），清空预览
                PreviewScoringItems.Clear();
                CurrentScoringModelName = "";
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
                Title = "新建评价体系",
                Content = "确定要初始化一个新的评价体系树吗？",
                ShowClose = true,
                IsConfirm = true,
                OnConfirmAsync = async () =>
                {
                    RootNodeId = await NodeService.CreateTree(CurrentCategory, $"{DateTime.Now.Year}年评价体系");
                    await Toast.Success("创建成功");
                    // 调用 Service 获取扁平数据
                    var nodes = await NodeService.GetNodesAsync(CurrentCategory, RootNodeId);

                    // 转换为树形结构
                    TreeItems = BuildTree(nodes, null);


                    await RefreshTreeAsync();
                    // 这里删除了 return true; 因为该委托不需要返回值
                }
            };
            await Swal.Show(op);
        }

        /// <summary>
        /// 2. 保存子节点 (表单提交)
        /// </summary>
        private async Task OnSaveNode(EditContext context)
        {
            try
            {
                if (SelectedNode == null) return;

                var updateDto = new UpdateNodeDto
                {
                    Id = CurrentNodeId, // 确保这是当前正在编辑的节点 ID
                    Category = CurrentCategory,
                    Name = CurrentEditModel.Name,
                    Code = CurrentEditModel.Code,
                    MaxScore = CurrentEditModel.MaxScore,
                    ScoringTemplateId = CurrentEditModel.ScoringTemplateId,
                    OrderIndex = CurrentEditModel.OrderIndex
                };

                // 🚀 实现【新增子节点】逻辑
                // 确保 ParentId 正确


                await NodeService.UpdateNode(updateDto);

                await Toast.Success("更新成功", $"指标 {CurrentEditModel.Name} 已更新");

                // 刷新树
                await RefreshTreeAsync();

                // 刷新后保持父节点选中状态略复杂，这里简单处理：清空选中，强迫用户重新点，防止数据错乱
                // 实际优化：可以通过保存 ID 重新 Find 并 Select

                // 简单重置表单部分字段以便连续添加
                // 刷新后，保持选中状态/重置表单（根据您的偏好）
                // 这里可以调用 OnTreeItemClick 重新选中父节点 (如果是在新增子节点后)

            }
            catch (Exception ex)
            {
                await Toast.Error("保存失败", ex.Message);
            }
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
    }
}