
using Microsoft.AspNetCore.Mvc;
using VideosChallenge.Application.Services.Interfaces;

namespace VideosChallenge.API.Controllers
{
    [ApiVersion("1.0")]
    [Route("/v{version:apiVersion}/videos")]
    public class VideosController : BaseController
    {
        private readonly IVideoService _videoService;

        public VideosController(IVideoService videoService)
        {
            _videoService = videoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVideos()
        {
            var result = await _videoService.GetAllVideos();
            return ResponseCustomizada(result);
        }
    }
}
