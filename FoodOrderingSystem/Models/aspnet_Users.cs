namespace FoodOrderingSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class aspnet_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public aspnet_Users()
        {
            aspnet_PersonalizationPerUser = new HashSet<aspnet_PersonalizationPerUser>();
            aspnet_PersonalizationPerUser1 = new HashSet<aspnet_PersonalizationPerUser>();
            aspnet_PersonalizationPerUser2 = new HashSet<aspnet_PersonalizationPerUser>();
            aspnet_UsersInRoles = new HashSet<aspnet_UsersInRoles>();
            aspnet_UsersInRoles1 = new HashSet<aspnet_UsersInRoles>();
            aspnet_UsersInRoles2 = new HashSet<aspnet_UsersInRoles>();
            FoodCompanies = new HashSet<FoodCompany>();
            FoodCompanies1 = new HashSet<FoodCompany>();
            FoodCompanies2 = new HashSet<FoodCompany>();
        }

        public Guid ApplicationId { get; set; }

        [Key]
        public Guid UserId { get; set; }

        [Required]
        [StringLength(256)]
        public string UserName { get; set; }

        [Required]
        [StringLength(256)]
        public string LoweredUserName { get; set; }

        [StringLength(16)]
        public string MobileAlias { get; set; }

        public bool IsAnonymous { get; set; }

        public DateTime LastActivityDate { get; set; }

        public virtual aspnet_Applications aspnet_Applications { get; set; }

        public virtual aspnet_Applications aspnet_Applications1 { get; set; }

        public virtual aspnet_Applications aspnet_Applications2 { get; set; }

        public virtual aspnet_Membership aspnet_Membership { get; set; }

        public virtual aspnet_Membership aspnet_Membership1 { get; set; }

        public virtual aspnet_Membership aspnet_Membership2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser2 { get; set; }

        public virtual aspnet_Profile aspnet_Profile { get; set; }

        public virtual aspnet_Profile aspnet_Profile1 { get; set; }

        public virtual aspnet_Profile aspnet_Profile2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aspnet_UsersInRoles> aspnet_UsersInRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aspnet_UsersInRoles> aspnet_UsersInRoles1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<aspnet_UsersInRoles> aspnet_UsersInRoles2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodCompany> FoodCompanies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodCompany> FoodCompanies1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoodCompany> FoodCompanies2 { get; set; }
    }
}
