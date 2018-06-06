namespace sale.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProductsTable")]
    public partial class ProductsTable
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string product { get; set; }

        public int price { get; set; }
    }
}
