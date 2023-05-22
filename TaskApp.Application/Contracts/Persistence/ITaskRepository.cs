using TaskApp.Domain;
namespace TaskApp.Application.Contracts.Persistence

{
    public interface ITasksRepository : IGenericRepository<Domain.Task>
    {
         
    }
}