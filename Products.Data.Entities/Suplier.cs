namespace Products.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Suplier
    {
        public int SuplierId { get; set; }

        [Required]
        [StringLength(50)]
        public string SuplierName { get; set; }

        public string Address { get; set; }
    }
}
