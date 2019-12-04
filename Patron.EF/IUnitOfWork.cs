using System;

namespace Patron.EF
{
    public interface IUnitOfWork : IDisposable
    {
        ITailsCardRepository Customers { get; }

        int Complete();
    }
}