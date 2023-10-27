using FilmesChallenge.Data.Contexts;
using FilmesChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using VideosChallenge.Data.Repositories.Interfaces;

namespace VideosChallenge.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        public readonly DbSet<TEntity> _dbSet;
        public readonly VideosContext _context;

        public BaseRepository(VideosContext context)
        {
            _dbSet = context.Set<TEntity>();
            _context = context;
        }

        public async Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            var query = _dbSet.AsQueryable();

            if (filter != null)
                query = query
                    .Where(filter)
                    .AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
