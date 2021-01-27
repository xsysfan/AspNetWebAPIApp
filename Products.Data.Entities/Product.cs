namespace Products.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int ProductId { get; set; }

        [StringLength(10)]
        public string ProductName { get; set; }

        public int CategoryId { get; set; }

        public int SuplierId { get; set; }

        [Column(TypeName = "money")]
        public decimal? Price { get; set; }
    }
}
