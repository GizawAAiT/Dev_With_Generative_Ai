namespace TaskApp.Application.Contracts.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        ITasksRepository TaskRepository{get;}
        IChecklistRepository ChecklistRepository{get;}

        Task<int> Save(); 
         
    }
}