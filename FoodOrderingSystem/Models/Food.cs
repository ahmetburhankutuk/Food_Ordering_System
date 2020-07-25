namespace FoodOrderingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Food")]
    public partial class Food
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Food()
        {
            BasketDetails = new HashSet<BasketDetail>();
            BasketDetails1 = new HashSet<BasketDetail>();
            BasketDetails2 = new HashSet<BasketDetail>();
            OrderInfoes = new HashSet<OrderInfo>();
            OrderInfoes1 = new HashSet<OrderInfo>();
            OrderInfoes2 = new HashSet<OrderInfo>();
        }

        public int FoodID { get; set; }

        public int? CategoryID { get; set; }

        [StringLength(50)]
        public string FoodName { get; set; }

        [StringLength(500)]
        public string FoodDefinition { get; set; }

        public int? Amount { get; set; }

        public double? Price { get; set; }

        public double? TotalPrice { get; set; }

        public DateTime? Edate { get; set; }

        public int? ResimID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasketDetail> BasketDetails { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasketDetail> BasketDetails1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BasketDetail> BasketDetails2 { get; set; }

        public virtual Category Category { get; set; }

        public virtual Category Category1 { get; set; }

        public virtual Category Category2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderInfo> OrderInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderInfo> OrderInfoes1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderInfo> OrderInfoes2 { get; set; }

        public virtual Resim Resim { get; set; }
    }
}
