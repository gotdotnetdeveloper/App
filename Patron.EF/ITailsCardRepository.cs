using System.Collections.Generic;

using Patron.EF.EFMap;

namespace Patron.EF
{
    public interface ITailsCardRepository : IRepository<TaisCard>
    {
        IEnumerable<TaisCard> GetBestCustomers(int amountOfCustomers);
    }
}