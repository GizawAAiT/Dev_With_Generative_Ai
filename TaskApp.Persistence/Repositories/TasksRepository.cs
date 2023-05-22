using TaskApp.Application.Contracts.Persistence;
using TaskApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
