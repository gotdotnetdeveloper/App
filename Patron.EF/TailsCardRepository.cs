using System;
using System.Collections.Generic;
using System.Linq;
using Patron.EF.EFDataObjects;

namespace Patron.EF
{
    public class TailsCardRepository : Repository<TailsCard>, ITailsCardRepository
    {
        private readonly PatronEntities _customerDbEntities;

        public TailsCardRepository(PatronEntities context) : base(context)
        {
            _customerDbEntities = context;
        }

        public IEnumerable<TailsCard> GetBestCustomers(int amountOfCustomers)
        {
            if (amountOfCustomers > _customerDbEntities.TailsCard.ToList().Count)
            {
                throw new IndexOutOfRangeException();
            }

            return _customerDbEntities.TailsCard.OrderByDescending(x => x.CardDate).Take(amountOfCustomers).ToList();
        }
    }
}
