

namespace Ordering.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastuctureServices
            (this IServiceCollection services, IConfiguration configuration)
        {
            var connectionstrring = configuration.GetConnectionString("Database");
                services.AddDbContext<ApplicationDbContext>(options=> 
                options.UseSqlServer(connectionstrring));
            return services;    
        }
    }
}
