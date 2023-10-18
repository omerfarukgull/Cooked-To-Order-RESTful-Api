using Microsoft.EntityFrameworkCore;
using CookedToOrderData.Concrete.Config;
using CookedToOrderEntity.Models;

namespace CookedToOrderData.Concrete
{
    public class FoodContext :DbContext
    {
        public FoodContext(DbContextOptions options):base(options) { }
        
       public DbSet<Food> Foods { get; set; } 
       public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FoodConfig());
            modelBuilder.ApplyConfiguration(new CategoryConfig());
        }
    }
}
