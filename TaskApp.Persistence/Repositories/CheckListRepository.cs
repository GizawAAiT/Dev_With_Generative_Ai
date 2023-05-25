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
