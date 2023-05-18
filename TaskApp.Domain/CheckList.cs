// CheckList.cs (Domain project)
using TaskApp.Common;
namespace TaskApp.Domain
{
    public class CheckList : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int TaskId { get; set; }
    }
}
