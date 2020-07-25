namespace FoodOrderingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class aspnet_Paths
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public aspnet_Paths()
        {
            aspnet_PersonalizationPerUser = new HashSet<aspnet_PersonalizationPerUser>();
            aspnet_PersonalizationPerUser1 = new HashSet<aspnet_PersonalizationPerUser>();
            aspnet_PersonalizationPerUser2 = new HashSet<aspnet_PersonalizationPerUser>();
        }

        public Guid ApplicationId { get; set; }

        [Key]
        public Guid PathId { get; set; }

        [Required]
        [StringLength(256)]
        public string Path { get; set; }

        [Required]
        [StringLength(256)]
        public string LoweredPath { get; set; }

        public virtual aspnet_Applications aspnet_Applications { get; set; }

        public virtual aspnet_Applications aspnet_Applications1 { get; set; }

        public virtual aspnet_Applications aspnet_Applications2 { get; set; }

        public virtual aspnet_PersonalizationAllUsers aspnet_PersonalizationAllUsers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }

        public virtual aspnet_PersonalizationAllUsers aspnet_PersonalizationAllUsers1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser1 { get; set; }

        public virtual aspnet_PersonalizationAllUsers aspnet_PersonalizationAllUsers2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser2 { get; set; }
    }
}