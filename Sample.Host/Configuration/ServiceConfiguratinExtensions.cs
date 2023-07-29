using Microsoft.EntityFrameworkCore;
using Sample.Core;
using Sample.EntityFramework.Commands;
using Sample.EntityFramework.Queries;

namespace Sample.Host
{
    public static class ServiceConfiguratinExtensions
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.RegisterApplicationService();
        }

        public static void RegisterQueryDbContext(this IServiceCollection services, IConfigurationRoot configuration)
        {
            var connectionString = configuration.GetSection("ConnectionStrings:Default")?.Value;
            services.AddDbContext<SampleQueryDbContext>(options => options.
                UseSqlServer(connectionString));
        }
        public static void RegisterCommandDbContext(this IServiceCollection services, IConfigurationRoot configuration)
        {
            var connectionString = configuration.GetSection("ConnectionStrings:Default")?.Value;
            services.AddDbContext<SampleCommandDbContext>(options => options.
                UseSqlServer(connectionString));
        }
        public static void RegisterQueryRepository(this IServiceCollection services)
        {
            var appicationServiceDomain = typeof(Sample.Application.SampleApplicationModule).Assembly;
            var appicationServices = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(ISampleQueryRepository).IsAssignableFrom(p) && !p.IsInterface);
            foreach (var service in appicationServices)
            {
                services.AddTransient(service);
            }
        }
        private static void RegisterApplicationService(this IServiceCollection services)
        {
            var appicationServiceDomain = typeof(Sample.Application.SampleApplicationModule).Assembly;
            var appicationServices = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(IApplicationService).IsAssignableFrom(p) && !p.IsInterface);
            foreach (var service in appicationServices)
            {
                services.AddTransient(service);
            }
        }
    }
}