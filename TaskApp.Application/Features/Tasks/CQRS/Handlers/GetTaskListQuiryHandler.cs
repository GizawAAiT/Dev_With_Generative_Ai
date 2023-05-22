public class GetTasksQueryHandler : IRequestHandler<GetTasksQuery, List<TaskDto>>
{
    private readonly ITaskRepository _taskRepository;

    public GetTasksQueryHandler(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<List<TaskDto>> Handle(GetTasksQuery request, CancellationToken cancellationToken)
    {
        // Retrieve all tasks from the repository
        var tasks = await _taskRepository.GetAllTasks();

        // Map Task entities to TaskDtos
        var taskDtos = tasks.Select(task => new TaskDto
        {
            Id = task.Id,
            Title = task.Title,
            Description = task.Description,
            StartDate = task.StartDate,
            EndDate = task.EndDate,
            IsCompleted = task.IsCompleted,
            Checklists = task.Checklists.Select(c => new ChecklistDto
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description,
                IsCompleted = c.IsCompleted
            }).ToList()
        }).ToList();

        return taskDtos;
    }
}
