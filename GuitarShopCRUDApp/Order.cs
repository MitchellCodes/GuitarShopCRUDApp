namespace GuitarShopCRUDApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int OrderID { get; set; }

        public int? CustomerID { get; set; }

        public DateTime OrderDate { get; set; }

        [Column(TypeName = "money")]
        public decimal ShipAmount { get; set; }

        [Column(TypeName = "money")]
        public decimal TaxAmount { get; set; }

        public DateTime? ShipDate { get; set; }

        public int ShipAddressID { get; set; }

        [Required]
        [StringLength(50)]
        public string CardType { get; set; }

        [Required]
        [StringLength(16)]
        public string CardNumber { get; set; }

        [Required]
        [StringLength(7)]
        public string CardExpires { get; set; }

        public int BillingAddressID { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
