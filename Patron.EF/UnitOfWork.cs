using Patron.EF.EFDataObjects;

namespace Patron.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly PatronEntities _context;

        public UnitOfWork(PatronEntities context)
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
