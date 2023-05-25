using TaskApp.Application.Contracts.Persistence;

namespace TaskApp.Persistence.Repositories
{
    public class TasksRepository : GenericRepository<Tasks>, ITasksRepository
    {
        private readonly TaskAppDbContext _context;
        public TasksRepository(TaskAppDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
    }
}
