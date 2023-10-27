using Microsoft.Extensions.DependencyInjection;
using VideosChallenge.Application.Services;
using VideosChallenge.Application.Services.Interfaces;

namespace VideosChallenge.Infrastructure.Extensions
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IVideoService, VideoService>();
            return services;
        }
    }
}
