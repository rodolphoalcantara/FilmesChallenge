using Microsoft.Extensions.DependencyInjection;
using VideosChallenge.Data.Repositories;
using VideosChallenge.Data.Repositories.Interfaces;

namespace VideosChallenge.Infrastructure.Extensions
{
    public static class RepositoryConfiguration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            return services;
        }
    }
}
