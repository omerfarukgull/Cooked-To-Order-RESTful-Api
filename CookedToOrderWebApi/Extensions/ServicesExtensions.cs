using CookedToFoodPresentation.ActionFilter;
using CookedToOrderBusiness.Abstract;
using CookedToOrderBusiness.Concrete;
using CookedToOrderData.Abstract;
using CookedToOrderData.Concrete;
using Microsoft.EntityFrameworkCore;
using Presentation.ActionFilter;
using Services.Abstract;
using Services.Concrete;

namespace CookedToOrderWebApi.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services,IConfiguration configuration )
        {
            services.AddDbContext<FoodContext>(ops => ops.UseSqlServer(configuration.GetConnectionString("sqlConnection")));
        }
        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IRepositoryManager , RepositoryManager>();
        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>();
        public static void ConfigureActionFilters(this IServiceCollection services)
        {
            services.AddScoped<ValidationFilterAttribute>();
            services.AddSingleton<LogFiterAttribute>();
        }
        public static void ConfigureLoggerService(this IServiceCollection services) =>
            services.AddSingleton<ILoggerService, LoggerManager>();
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(ops =>
            {
                ops.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .WithExposedHeaders("X-Pagination")
                ) ;
            });
        }

    }
}
