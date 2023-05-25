namespace TaskApp.Application.Features.Task.DTOs
{
    public interface ITaskDto
    {
        string Title { get; set; }
        string Description { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        bool IsCompleted { get; set; }
    }

}