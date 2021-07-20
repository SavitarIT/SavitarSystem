using Microsoft.Extensions.DependencyInjection;

namespace Savitar.Web.Bootstrapper
{
    public static class Bootstrap
    {
        public static void Execute(IServiceCollection services)
        {
            Data.DI.Execute(services);
            Services.DI.Execute(services);
        }
    }
}
