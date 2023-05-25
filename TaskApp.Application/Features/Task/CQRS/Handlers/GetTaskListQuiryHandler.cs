using MediatR;
using TaskApp.Application.Features.Task.CQRS.Queries;
using TaskApp.Application.Features.Task.DTOs;

public class GetTaskListQueryHandler : IRequestHandler<GetTaskListQuery, List<TaskDto>>
{
	private readonly ITaskRepository _taskRepository;

	public GetTaskListQueryHandler(ITaskRepository taskRepository)
	{
		_taskRepository = taskRepository;
	}

	public async Task<List<TaskDto>> Handle(GetTaskListQuery request, CancellationToken cancellationToken)
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
			checklists = task.Checklists.Select(c => new ChecklistDto
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
