namespace Sale.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.IO;

    public partial class ContactsTable : DbContext
    {
        public ContactsTable()
            : base("name=ContactsTable")
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory());

        }

        public virtual DbSet<ProductsTable> ProductsTable { get; set; }
        public virtual DbSet<SaleTable> SaleTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
