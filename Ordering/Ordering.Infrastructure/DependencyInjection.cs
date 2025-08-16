using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastuctureServices
            (this IServiceCollection services, IConfiguration configuration)
        {
            var connectionstrring = configuration.GetConnectionString("Database");
            // Add services to the container.
            //services.AddScoped<ISaveChangesInterceptor, AuditableEntityInterceptor>();
            //services.AddScoped<ISaveChangesInterceptor, DispatchDomainEventsInterceptor>();

            //services.AddDbContext<ApplicationDbContext>((sp, options) =>
            //{
            //    options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());
            //    options.UseSqlServer(connectionString);
            //});

            //services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            return services;    
        }
    }
}
