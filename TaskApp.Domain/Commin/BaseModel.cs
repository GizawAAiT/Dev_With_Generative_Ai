// BaseModel.cs (Common folder)
namespace TaskApp.Domain.Common
{
    public abstract class BaseModel 
    {
        public int Id { get; set; }
        public bool IsCompleted { get; set; }
    }
}
