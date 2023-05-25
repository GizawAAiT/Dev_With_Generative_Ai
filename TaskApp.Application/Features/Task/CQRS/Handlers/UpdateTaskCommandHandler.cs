using MediatR;
using TaskApp.Application.Features.Task.CQRS.Commands;
using TaskApp.Application.Features.Task.DTOs;



namespace TaskApp.Application.Features.Task.CQRS.Handlers
{
	public class UpdateTaskCommandHandler : IRequestHandler<UpdateTaskCommand, TaskDto>
	{
		private readonly ITaskRepository _taskRepository;

		public UpdateTaskCommandHandler(ITaskRepository taskRepository)
		{
			_taskRepository = taskRepository;
		}

		public async Task<TaskDto> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
		{
			// Retrieve the existing task from the repository
			var task = await _taskRepository.GetTaskById(request.Id);

			if (task == null)
			{
				// Handle task not found error
				// You can throw an exception or return an appropriate response
			}

			// Update the task with the new values
			task.Title = request.Title;
			task.Description = request.Description;
			task.StartDate = request.StartDate;
			task.EndDate = request.EndDate;

			// Save the updated task
			await _taskRepository.UpdateTask(task);

			// Map Task entity to TaskDto
			var taskDto = new TaskDto
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
			};

			return taskDto;
		}
	}
}