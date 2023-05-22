
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskApp.Application.Contracts.Persistence;
using TaskApp.Domain;
using TaskApp.Persistence.Repositories;

namespace TaskApp.Persistence.Repositories
{
    public class CheckListRepository : GenericRepository<CheckList>, ICheckListRepository
    {
        private readonly TaskAppDbContext _context;
        public CheckListRepository(TaskAppDbContext dbContext) : base(dbContext)
        {
            _context = dbContext;
        }
    }
}
