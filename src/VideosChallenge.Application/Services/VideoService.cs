using FilmesChallenge.Domain.Entities;
using VideosChallenge.Application.Services.Interfaces;
using VideosChallenge.Data.Repositories.Interfaces;

namespace VideosChallenge.Application.Services
{
    public class VideoService : IVideoService
    {
        private readonly IVideoRepository _videoRepository;

        public VideoService(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }

        public Task<IEnumerable<VideoEntity>> GetAllVideos()
        {
            return _videoRepository.GetAll();
        }
    }
}
