namespace new_Entity.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.IO;

    public partial class ContactsModel : DbContext
    {
        public ContactsModel()
            : base("name=ContactsModel")
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", Dire ctory.GetCurrentDirectory());
        }

        public virtual DbSet<ContactsTable> ContactsTable { get; set; }// 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
