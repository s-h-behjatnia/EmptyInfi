
using Microsoft.EntityFrameworkCore;
using Sample.EntityFramework.Queries;

namespace Sample.Host
{
    public class Startup
    {
        private readonly IConfigurationRoot _appConfiguration;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public Startup(IWebHostEnvironment env)
        {
            _hostingEnvironment = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var config = _appConfiguration.GetSection("App");
            services.AddSingleton(config);
            services.ConfigureServices();
            services.RegisterQueryDbContext(_appConfiguration);
            services.RegisterCommandDbContext(_appConfiguration);
            services.RegisterQueryRepository();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            app.UseStaticFiles();
            app.UseSwagger();
            app.UseSwaggerUI();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}");
            });
        }
    }
}