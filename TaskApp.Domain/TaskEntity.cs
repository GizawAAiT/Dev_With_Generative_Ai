// Task.cs (Domain project)
using TaskApp.Domain.Common;

namespace TaskApp.Domain
{
    public class TaskEntity : BaseModel
    {
        public int OwnerId { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
