namespace FoodOrderingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BranchOffice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BranchOffice()
        {
            Shippings = new HashSet<Shipping>();
            Shippings1 = new HashSet<Shipping>();
            Shippings2 = new HashSet<Shipping>();
        }

        [Key]
        public int OfficeID { get; set; }

        public int? CompanyID { get; set; }

        [StringLength(100)]
        public string OffficeName { get; set; }

        public int? BranchCode { get; set; }

        public virtual FoodCompany FoodCompany { get; set; }

        public virtual FoodCompany FoodCompany1 { get; set; }

        public virtual FoodCompany FoodCompany2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shipping> Shippings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shipping> Shippings1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shipping> Shippings2 { get; set; }
    }
}
