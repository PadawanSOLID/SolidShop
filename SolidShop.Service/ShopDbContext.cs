using Microsoft.EntityFrameworkCore;
using SolidShop.Model.Entities;

namespace SolidShop.Service
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected ShopDbContext()
        {
        }

        public DbSet<GoodsCategory> GoodsCategories { get; set; }

        public DbSet<Good> Goods { get; set; }
    }
}
