namespace HW6.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TicketTable")]
    public partial class TicketTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Start { get; set; }

        [Required]
        [StringLength(50)]
        public string End { get; set; }

        public int Price { get; set; }
    }
}
