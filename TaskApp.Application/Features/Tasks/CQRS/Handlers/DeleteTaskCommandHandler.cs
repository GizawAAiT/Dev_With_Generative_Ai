public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand, bool>
{
    private readonly ITaskRepository _taskRepository;

    public DeleteTaskCommandHandler(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async Task<bool> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
    {
        // Retrieve the task from the repository
        var task = await _taskRepository.GetTaskById(request.TaskId);

        if (task == null)
        {
            // Handle task not found error
            // You can throw an exception or return an appropriate response
        }

        // Delete the task
        await _taskRepository.DeleteTask(task);

        return true; // Indicate successful deletion
    }
}
