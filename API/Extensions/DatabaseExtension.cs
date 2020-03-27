using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using Repository.Interfaces;

namespace API.Extensions
{
    public static class DatabaseExtension
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<TeamBlueTestContext>(
                o => { o.UseSqlServer(configuration.GetConnectionString("teambluedb")); });
            services.AddScoped<ITeamBlueTestContext>(ctx => ctx.GetService<TeamBlueTestContext>());

            return services;

        }
    }
}
