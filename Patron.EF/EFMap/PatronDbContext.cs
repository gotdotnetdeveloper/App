namespace Patron.EF.EFMap
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PatronDbContext : DbContext
    {
        public PatronDbContext()
            : base("name=Model1Connection")
        {
        }

        public virtual DbSet<TaisCard> TailsCard { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
