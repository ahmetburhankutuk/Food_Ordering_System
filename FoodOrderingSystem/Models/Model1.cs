namespace FoodOrderingSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public virtual DbSet<aspnet_Membership> aspnet_Membership { get; set; }
        public virtual DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public virtual DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public virtual DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public virtual DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public virtual DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public virtual DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public virtual DbSet<aspnet_Users> aspnet_Users { get; set; }
        public virtual DbSet<aspnet_UsersInRoles> aspnet_UsersInRoles { get; set; }
        public virtual DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }
        public virtual DbSet<Basket> Baskets { get; set; }
        public virtual DbSet<BasketDetail> BasketDetails { get; set; }
        public virtual DbSet<BranchOffice> BranchOffices { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CreditCard> CreditCards { get; set; }
        public virtual DbSet<Food> Foods { get; set; }
        public virtual DbSet<FoodCompany> FoodCompanies { get; set; }
        public virtual DbSet<OrderInfo> OrderInfoes { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Resim> Resims { get; set; }
        public virtual DbSet<Shipping> Shippings { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<vw_aspnet_Applications> vw_aspnet_Applications { get; set; }
        public virtual DbSet<vw_aspnet_MembershipUsers> vw_aspnet_MembershipUsers { get; set; }
        public virtual DbSet<vw_aspnet_Profiles> vw_aspnet_Profiles { get; set; }
        public virtual DbSet<vw_aspnet_Roles> vw_aspnet_Roles { get; set; }
        public virtual DbSet<vw_aspnet_Users> vw_aspnet_Users { get; set; }
        public virtual DbSet<vw_aspnet_UsersInRoles> vw_aspnet_UsersInRoles { get; set; }
        public virtual DbSet<vw_aspnet_WebPartState_Paths> vw_aspnet_WebPartState_Paths { get; set; }
        public virtual DbSet<vw_aspnet_WebPartState_Shared> vw_aspnet_WebPartState_Shared { get; set; }
        public virtual DbSet<vw_aspnet_WebPartState_User> vw_aspnet_WebPartState_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Membership)
                .WithRequired(e => e.aspnet_Applications)
                .HasForeignKey(e => e.ApplicationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Membership1)
                .WithRequired(e => e.aspnet_Applications1)
                .HasForeignKey(e => e.ApplicationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Membership2)
                .WithRequired(e => e.aspnet_Applications2)
                .HasForeignKey(e => e.ApplicationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Paths)
                .WithRequired(e => e.aspnet_Applications)
                .HasForeignKey(e => e.ApplicationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Paths1)
                .WithRequired(e => e.aspnet_Applications1)
                .HasForeignKey(e => e.ApplicationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Paths2)
                .WithRequired(e => e.aspnet_Applications2)
                .HasForeignKey(e => e.ApplicationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Roles)
                .WithRequired(e => e.aspnet_Applications)
                .HasForeignKey(e => e.ApplicationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Roles1)
                .WithRequired(e => e.aspnet_Applications1)
                .HasForeignKey(e => e.ApplicationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Roles2)
                .WithRequired(e => e.aspnet_Applications2)
                .HasForeignKey(e => e.ApplicationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Users)
                .WithRequired(e => e.aspnet_Applications)
                .HasForeignKey(e => e.ApplicationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Users1)
                .WithRequired(e => e.aspnet_Applications1)
                .HasForeignKey(e => e.ApplicationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Users2)
                .WithRequired(e => e.aspnet_Applications2)
                .HasForeignKey(e => e.ApplicationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Paths>()
                .HasOptional(e => e.aspnet_PersonalizationAllUsers)
                .WithRequired(e => e.aspnet_Paths);

            modelBuilder.Entity<aspnet_Paths>()
                .HasMany(e => e.aspnet_PersonalizationPerUser)
                .WithOptional(e => e.aspnet_Paths)
                .HasForeignKey(e => e.PathId);

            modelBuilder.Entity<aspnet_Paths>()
                .HasOptional(e => e.aspnet_PersonalizationAllUsers1)
                .WithRequired(e => e.aspnet_Paths1);

            modelBuilder.Entity<aspnet_Paths>()
                .HasMany(e => e.aspnet_PersonalizationPerUser1)
                .WithOptional(e => e.aspnet_Paths1)
                .HasForeignKey(e => e.PathId);

            modelBuilder.Entity<aspnet_Paths>()
                .HasOptional(e => e.aspnet_PersonalizationAllUsers2)
                .WithRequired(e => e.aspnet_Paths2);

            modelBuilder.Entity<aspnet_Paths>()
                .HasMany(e => e.aspnet_PersonalizationPerUser2)
                .WithOptional(e => e.aspnet_Paths2)
                .HasForeignKey(e => e.PathId);

            modelBuilder.Entity<aspnet_Roles>()
                .HasMany(e => e.aspnet_UsersInRoles)
                .WithRequired(e => e.aspnet_Roles)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Roles>()
                .HasMany(e => e.aspnet_UsersInRoles1)
                .WithRequired(e => e.aspnet_Roles1)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Roles>()
                .HasMany(e => e.aspnet_UsersInRoles2)
                .WithRequired(e => e.aspnet_Roles2)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.aspnet_Membership)
                .WithRequired(e => e.aspnet_Users);

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.aspnet_Membership1)
                .WithRequired(e => e.aspnet_Users1);

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.aspnet_Membership2)
                .WithRequired(e => e.aspnet_Users2);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.aspnet_PersonalizationPerUser)
                .WithOptional(e => e.aspnet_Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.aspnet_PersonalizationPerUser1)
                .WithOptional(e => e.aspnet_Users1)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.aspnet_PersonalizationPerUser2)
                .WithOptional(e => e.aspnet_Users2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.aspnet_Profile)
                .WithRequired(e => e.aspnet_Users);

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.aspnet_Profile1)
                .WithRequired(e => e.aspnet_Users1);

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.aspnet_Profile2)
                .WithRequired(e => e.aspnet_Users2);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.aspnet_UsersInRoles)
                .WithRequired(e => e.aspnet_Users)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.aspnet_UsersInRoles1)
                .WithRequired(e => e.aspnet_Users1)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.aspnet_UsersInRoles2)
                .WithRequired(e => e.aspnet_Users2)
                .HasForeignKey(e => e.UserId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.FoodCompanies)
                .WithOptional(e => e.aspnet_Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.FoodCompanies1)
                .WithOptional(e => e.aspnet_Users1)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<aspnet_Users>()
                .HasMany(e => e.FoodCompanies2)
                .WithOptional(e => e.aspnet_Users2)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventSequence)
                .HasPrecision(19, 0);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventOccurrence)
                .HasPrecision(19, 0);

            modelBuilder.Entity<Basket>()
                .HasMany(e => e.BasketDetails)
                .WithOptional(e => e.Basket)
                .HasForeignKey(e => e.BasketID);

            modelBuilder.Entity<Basket>()
                .HasMany(e => e.BasketDetails1)
                .WithOptional(e => e.Basket1)
                .HasForeignKey(e => e.BasketID);

            modelBuilder.Entity<Basket>()
                .HasMany(e => e.BasketDetails2)
                .WithOptional(e => e.Basket2)
                .HasForeignKey(e => e.BasketID);

            modelBuilder.Entity<BranchOffice>()
                .HasMany(e => e.Shippings)
                .WithOptional(e => e.BranchOffice)
                .HasForeignKey(e => e.OfficeID);

            modelBuilder.Entity<BranchOffice>()
                .HasMany(e => e.Shippings1)
                .WithOptional(e => e.BranchOffice1)
                .HasForeignKey(e => e.OfficeID);

            modelBuilder.Entity<BranchOffice>()
                .HasMany(e => e.Shippings2)
                .WithOptional(e => e.BranchOffice2)
                .HasForeignKey(e => e.OfficeID);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Foods)
                .WithOptional(e => e.Category)
                .HasForeignKey(e => e.CategoryID);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Foods1)
                .WithOptional(e => e.Category1)
                .HasForeignKey(e => e.CategoryID);

            modelBuilder.Entity<Category>()
                .HasMany(e => e.Foods2)
                .WithOptional(e => e.Category2)
                .HasForeignKey(e => e.CategoryID);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.BasketDetails)
                .WithOptional(e => e.Food)
                .HasForeignKey(e => e.FoodID);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.BasketDetails1)
                .WithOptional(e => e.Food1)
                .HasForeignKey(e => e.FoodID);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.BasketDetails2)
                .WithOptional(e => e.Food2)
                .HasForeignKey(e => e.FoodID);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.OrderInfoes)
                .WithRequired(e => e.Food)
                .HasForeignKey(e => e.FoodID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.OrderInfoes1)
                .WithRequired(e => e.Food1)
                .HasForeignKey(e => e.FoodID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Food>()
                .HasMany(e => e.OrderInfoes2)
                .WithRequired(e => e.Food2)
                .HasForeignKey(e => e.FoodID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FoodCompany>()
                .HasMany(e => e.BranchOffices)
                .WithOptional(e => e.FoodCompany)
                .HasForeignKey(e => e.CompanyID);

            modelBuilder.Entity<FoodCompany>()
                .HasMany(e => e.BranchOffices1)
                .WithOptional(e => e.FoodCompany1)
                .HasForeignKey(e => e.CompanyID);

            modelBuilder.Entity<FoodCompany>()
                .HasMany(e => e.BranchOffices2)
                .WithOptional(e => e.FoodCompany2)
                .HasForeignKey(e => e.CompanyID);

            modelBuilder.Entity<FoodCompany>()
                .HasMany(e => e.Categories)
                .WithOptional(e => e.FoodCompany)
                .HasForeignKey(e => e.CompanyID);

            modelBuilder.Entity<FoodCompany>()
                .HasMany(e => e.Categories1)
                .WithOptional(e => e.FoodCompany1)
                .HasForeignKey(e => e.CompanyID);

            modelBuilder.Entity<FoodCompany>()
                .HasMany(e => e.Categories2)
                .WithOptional(e => e.FoodCompany2)
                .HasForeignKey(e => e.CompanyID);

            modelBuilder.Entity<FoodCompany>()
                .HasMany(e => e.Shippings)
                .WithOptional(e => e.FoodCompany)
                .HasForeignKey(e => e.CompanyID);

            modelBuilder.Entity<FoodCompany>()
                .HasMany(e => e.Shippings1)
                .WithOptional(e => e.FoodCompany1)
                .HasForeignKey(e => e.CompanyID);

            modelBuilder.Entity<FoodCompany>()
                .HasMany(e => e.Shippings2)
                .WithOptional(e => e.FoodCompany2)
                .HasForeignKey(e => e.CompanyID);

            modelBuilder.Entity<OrderInfo>()
                .HasMany(e => e.Baskets)
                .WithRequired(e => e.OrderInfo)
                .HasForeignKey(e => e.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderInfo>()
                .HasMany(e => e.Baskets1)
                .WithRequired(e => e.OrderInfo1)
                .HasForeignKey(e => e.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderInfo>()
                .HasMany(e => e.Baskets2)
                .WithRequired(e => e.OrderInfo2)
                .HasForeignKey(e => e.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderInfo>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.OrderInfo)
                .HasForeignKey(e => e.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderInfo>()
                .HasMany(e => e.Payments1)
                .WithRequired(e => e.OrderInfo1)
                .HasForeignKey(e => e.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderInfo>()
                .HasMany(e => e.Payments2)
                .WithRequired(e => e.OrderInfo2)
                .HasForeignKey(e => e.OrderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OrderInfo>()
                .HasMany(e => e.Shippings)
                .WithOptional(e => e.OrderInfo)
                .HasForeignKey(e => e.OrderID);

            modelBuilder.Entity<OrderInfo>()
                .HasMany(e => e.Shippings1)
                .WithOptional(e => e.OrderInfo1)
                .HasForeignKey(e => e.OrderID);

            modelBuilder.Entity<OrderInfo>()
                .HasMany(e => e.Shippings2)
                .WithOptional(e => e.OrderInfo2)
                .HasForeignKey(e => e.OrderID);
        }
    }
}
