namespace GuitarShopCRUDApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderItem
    {
        [Key]
        public int ItemID { get; set; }

        public int? OrderID { get; set; }

        public int? ProductID { get; set; }

        [Column(TypeName = "money")]
        public decimal ItemPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal DiscountAmount { get; set; }

        public int Quantity { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}
