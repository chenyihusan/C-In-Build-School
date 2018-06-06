namespace sale.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesTable")]
    public partial class SalesTable
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Sales { get; set; }

        [Required]
        [StringLength(50)]
        public string product { get; set; }

        public int number { get; set; }
    }
}
