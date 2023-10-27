
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repositories.Concrete;

namespace WebApi.ContextFactory
{
    public class FoodContextFactory : IDesignTimeDbContextFactory<FoodContext>
    {
        public FoodContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<FoodContext>()
               .UseSqlServer(configuration.GetConnectionString("sqlConnection"),
               prj => prj.MigrationsAssembly("CookedToOrderWebApi"));
            return new FoodContext(builder.Options);
        }
    }
}
