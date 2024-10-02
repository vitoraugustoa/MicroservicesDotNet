using GeekShopping.ProductAPI.Repository;

namespace GeekShopping.ProductAPI.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
