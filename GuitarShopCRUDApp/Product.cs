namespace GuitarShopCRUDApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int ProductID { get; set; }

        public int? CategoryID { get; set; }

        [Required]
        [StringLength(10)]
        public string ProductCode { get; set; }

        [Required]
        [StringLength(255)]
        public string ProductName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Description { get; set; }

        [Column(TypeName = "money")]
        public decimal ListPrice { get; set; }

        [Column(TypeName = "money")]
        public decimal DiscountPercent { get; set; }

        public DateTime? DateAdded { get; set; }

        public virtual Category Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
