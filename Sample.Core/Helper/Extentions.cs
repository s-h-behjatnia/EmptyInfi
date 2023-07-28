using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Sample.Core
{
    public class Extentions
    {
        public static IService GetService<IService>()
        {
            var contextAccessor = new HttpContextAccessor();
            return contextAccessor.HttpContext.RequestServices.GetService<IService>();
        }
    }
}