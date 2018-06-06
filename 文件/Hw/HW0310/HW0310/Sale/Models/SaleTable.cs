namespace Sale.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SaleTable")]
    public partial class SaleTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Sales { get; set; }

        public int Pen { get; set; }

        public int Eraser { get; set; }

        public int Ruler { get; set; }

        public int Whiteout { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Pencil { get; set; }
    }
}
