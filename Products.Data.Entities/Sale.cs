namespace Products.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sale
    {
        [Key]
        public int TransactionId { get; set; }

        public int ProductId { get; set; }

        public int Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int SellerId { get; set; }

        public DateTime TransactionDate { get; set; }
    }
}
