
using Patron.EF.EFMap;

namespace Patron.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PatronDbContext _context;

        public UnitOfWork(PatronDbContext context)
        {
            _context = context;
            Customers = new TailsCardRepository(_context);
        }

        public ITailsCardRepository Customers { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
