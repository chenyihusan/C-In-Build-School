namespace Oil.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContactsModel : DbContext
    {
        public ContactsModel()
            : base("name=ContactsModel")
        {
        }

        public virtual DbSet<RefuleTable> RefuleTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
