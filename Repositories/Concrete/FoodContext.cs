using Microsoft.EntityFrameworkCore;
using Repositories.Concrete.Config;
using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Reflection;

namespace Repositories.Concrete
{
    public class FoodContext :IdentityDbContext<User>
    {
        public FoodContext(DbContextOptions options):base(options) { }
        
       public DbSet<Food> Foods { get; set; } 
       public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //modelBuilder.ApplyConfiguration(new FoodConfig());
            //modelBuilder.ApplyConfiguration(new CategoryConfig());
            //modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // IEntityTypeConfiguration ifadesini, kullanan class burada toplanıyor
        }
    }
}
