// using TaskApp.Application.Features.Common;

namespace TaskApp.Application.Features.Task.DTOs
{
    public class UpdateTaskDto : BaseDto, ITaskDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}