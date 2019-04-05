using System.Data.Entity;
using TyTyShop.Model.Models;

namespace TyTyShop.Data
{
    public class TyTyShopDbContext : DbContext
    {
        public TyTyShopDbContext() : base("TyTyShopConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Footer> footers { get; set; }
        public DbSet<Menu> menus { get; set; }
        public DbSet<MenuGroup> menuGroups { get; set; }
        public DbSet<Order> orders { get; set; }
        public DbSet<OrderDetail> orderDetails { get; set; }
        public DbSet<Pages> pages { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Postcategory> postcategories { get; set; }
        public DbSet<PostTag> postTags { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<ProductCategory> productCategories { get; set; }
        public DbSet<ProductTag> productTags { get; set; }
        public DbSet<Slide> slides { get; set; }
        public DbSet<SupportOnline> supportOnlines { get; set; }
        public DbSet<SystemConfig> systemConfigs { get; set; }
        public DbSet<Tag> tags { get; set; }
        public DbSet<VisitorStatistic> visitorStatistics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}