using FilmesChallenge.Data.Mapping;
using FilmesChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FilmesChallenge.Data.Contexts
{
    public class VideosContext : DbContext
    {
        public DbSet<VideoEntity> Videos { get; set; }

        public VideosContext(DbContextOptions<VideosContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new VideoMap());
        }
    }
}
