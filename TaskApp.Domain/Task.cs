// Task.cs (Domain project)
namespace TaskApp.Domain
{
    public class Task : BaseModel
    {
        public User Owner { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
