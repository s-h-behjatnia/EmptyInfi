using Sample.Core;

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