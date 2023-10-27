using FilmesChallenge.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace VideosChallenge.Infrastructure.Extensions
{
    public static class EntityFrameworkConfiguration
    {
        public static IServiceCollection ConfigureEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("VideosChallengeDBConn");

            services.AddDbContext<VideosContext>(options =>
                options.UseSqlServer(connectionString)
            );

            return services;
        }
    }
}
