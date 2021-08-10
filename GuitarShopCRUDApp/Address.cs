namespace GuitarShopCRUDApp
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Address
    {
        public int AddressID { get; set; }

        public int? CustomerID { get; set; }

        [Required]
        [StringLength(60)]
        public string Line1 { get; set; }

        [StringLength(60)]
        public string Line2 { get; set; }

        [Required]
        [StringLength(40)]
        public string City { get; set; }

        [Required]
        [StringLength(2)]
        public string State { get; set; }

        [Required]
        [StringLength(10)]
        public string ZipCode { get; set; }

        [Required]
        [StringLength(12)]
        public string Phone { get; set; }

        public int Disabled { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
