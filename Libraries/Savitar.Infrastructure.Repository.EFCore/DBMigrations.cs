using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Savitar.Infrastructure.Repository.EFCore
{
    public static class DBMigrations
    {
        public static void Execute(IServiceScope scope)
        {
            var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            db.Database.Migrate();
        }
    }
}
