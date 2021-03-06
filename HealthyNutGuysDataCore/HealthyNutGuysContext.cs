using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HealthyNutGuysDomain.Models;
using HealthyNutGuysDataCore.Configurations;

namespace HealthyNutGuysDataCore
{
    public class HealthyNutGuysContext : IdentityDbContext<ApplicationUser>
    {
        public HealthyNutGuysContext(DbContextOptions<HealthyNutGuysContext> options) : base(options) { }
        public HealthyNutGuysContext() { }        
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CustomProduct> CustomProducts { get; set; }        
        public DbSet<ProductDetails> ProductDetails { get; set; }
        public DbSet<PromoCode> PromoCodes { get; set; }
        public DbSet<Tag> Tags { get; set; }            
        public DbSet<MixCategory> MixCategories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<UserSubscription> UserSubscriptions { get; set; }
        public DbSet<SubscriptionOffer> SubscriptionOffers { get; set; }
        public DbSet<SpecialOffer> SpecialOffers { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
        public DbSet<SelectOption> SelectOptions { get; set; }
        public DbSet<CustomSelectOption> CustomSelectOptions { get; set; }
        public DbSet<UserSubscriptionProduct> UserSubscriptionProducts { get; set; }
        public DbSet <UserSubscriptionMixCategory> UserSubscriptionMixCategories { get; set; }
        public DbSet<UserSubscriptionMixCategoryIngredient> UserSubscriptionMixCategoryIngredient { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            new TagConfiguration(builder.Entity<Tag>());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}