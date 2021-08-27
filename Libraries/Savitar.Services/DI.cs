using Microsoft.Extensions.DependencyInjection;
using Savitar.Services.Shared;

namespace Savitar.Services
{
    public static class DI
    {
        public static void Execute(IServiceCollection services)
        {
            services.AddTransient<IUserService, UsersService>();
        }
    }
}
