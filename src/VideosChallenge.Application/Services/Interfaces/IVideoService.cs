using FilmesChallenge.Domain.Entities;
using System.Threading.Tasks;

namespace VideosChallenge.Application.Services.Interfaces
{
    public interface IVideoService
    {
        Task<IEnumerable<VideoEntity>> GetAllVideos();
    }
}
