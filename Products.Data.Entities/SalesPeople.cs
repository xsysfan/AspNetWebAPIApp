namespace Products.Data.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesPeople")]
    public partial class SalesPeople
    {
        [Key]
        public int SellerId { get; set; }

        [Required]
        [StringLength(50)]
        public string SellerName { get; set; }

        [Required]
        [StringLength(50)]
        public string SellerSurname { get; set; }

        [Required]
        [StringLength(50)]
        public string SellerPhone { get; set; }

        public string Address { get; set; }

        [StringLength(50)]
        public string PersonalID { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
