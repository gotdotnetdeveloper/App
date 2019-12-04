using System.Collections.Generic;
using Patron.EF.EFDataObjects;

namespace Patron.EF
{
    public interface ITailsCardRepository : IRepository<TailsCard>
    {
        IEnumerable<TailsCard> GetBestCustomers(int amountOfCustomers);
    }
}