using Furion.DatabaseAccessor;
using Furion.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Tsjy.Application.System.Dtos.InspectionDtos;
using Tsjy.Application.System.IService;
using Tsjy.Core.Entities;
using Tsjy.Core.Enums;

namespace Tsjy.Application.System.Service;

public class InspectorTaskService : IInspectorTaskService, ITransient, IScoped
{
    private readonly IRepository<Inspection> _inspectionRepo;
    private readonly IRepository<Tasks> _taskRepo;
    private readonly IRepository<Departments> _deptRepo;

    public InspectorTaskService(
        IRepository<Inspection> inspectionRepo,
        IRepository<Tasks> taskRepo,
        IRepository<Departments> deptRepo)
    {
        _inspectionRepo = inspectionRepo;
        _taskRepo = taskRepo;
        _deptRepo = deptRepo;
    }

    public async Task<List<InspectorTaskDto>> GetMyInspectionsAsync(string expertId)
    {
        // 联表查询：Inspection -> Tasks -> Departments
        var query = from i in _inspectionRepo.AsQueryable()
                    join t in _taskRepo.AsQueryable() on i.TaskId equals t.Id
                    join d in _deptRepo.AsQueryable() on t.TargetId equals d.Id.ToString() // 假设 TargetId 是学校ID
                    where i.ExpertId == expertId // 筛选当前专家的任务
                    select new InspectorTaskDto
                    {
                        TaskId = t.Id,
                        TaskName = t.Name,
                        SchoolName = d.Name,
                        InspectionStart = i.StartDate,
                        InspectionEnd = i.EndDate,
                        Status = i.Status
                    };

        return await query.OrderByDescending(x => x.InspectionStart).ToListAsync();
    }

    public async Task<bool> ValidateInspectionAccessAsync(long taskId, string expertId)
    {
        return await _inspectionRepo.AnyAsync(x => x.TaskId == taskId && x.ExpertId == expertId);
    }
}