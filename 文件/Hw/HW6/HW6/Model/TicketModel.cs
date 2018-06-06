namespace HW6.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.IO;

    public partial class TicketModel : DbContext
    {
        public TicketModel()
            : base("name=TicketModel")
        {
            AppDomain.CurrentDomain.SetData("DAtaDirectory", Directory.GetCurrentDirectory());
        }

        public virtual DbSet<TicketTable> TicketTable { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
