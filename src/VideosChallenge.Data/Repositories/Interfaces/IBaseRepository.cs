using FilmesChallenge.Domain.Entities;
using System.Linq.Expressions;

namespace VideosChallenge.Data.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        Task<IEnumerable<TEntity>> Get(Expression<Func<TEntity, bool>> filter = null);
        Task<TEntity> GetByIdAsync(Guid id);
        Task AddAsync(TEntity entity);
        Task DeleteAsync(TEntity entity);
        Task Update(TEntity entity);
    }
}
