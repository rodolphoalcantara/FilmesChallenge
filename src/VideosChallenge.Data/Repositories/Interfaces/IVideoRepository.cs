using FilmesChallenge.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideosChallenge.Data.Repositories.Interfaces
{
    public interface IVideoRepository
    {
        Task<IEnumerable<VideoEntity>> GetAll();
    }
}
