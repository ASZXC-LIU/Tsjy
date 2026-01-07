//using Microsoft.AspNetCore.Components;
//using Microsoft.AspNetCore.Components.Authorization;
//using System.Security.Claims;
//using Tsjy.Application.System.Dtos.InspectionDtos;
//using Tsjy.Application.System.IService;

//namespace Tsjy.Web.Entry.Pages.Inspection;

//public partial class MyInspections
//{
//    [Inject] private IInspectionService InspectionService { get; set; }
//    [Inject] private AuthenticationStateProvider AuthStateProvider { get; set; }

//    private List<InspectorTaskDto> Tasks1 { get; set; } = new();

//    protected override async Task OnInitializedAsync()
//    {
//        var state = await AuthStateProvider.GetAuthenticationStateAsync();
//        // 获取当前用户IDNumber (Sid)
//        var userId = state.User.FindFirst(ClaimTypes.Sid)?.Value;

//        if (!string.IsNullOrEmpty(userId))
//        {
//            Tasks1 = await InspectionService.GetMyInspectionsAsync(userId);
//        }
//    }
//}