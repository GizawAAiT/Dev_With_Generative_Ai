// CheckList.cs (Domain project)
using TaskApp.Domain.Common;
namespace TaskApp.Domain
{
    public class Checklist : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int TaskId { get; set; }
    }
}
