using BotOS.Domain.Common;
using System.Linq.Expressions;

namespace BotOS.Persistence.Repo.Abstraction
{
    public interface IRepository<TEntity> where TEntity : IEntityBase
    {
        public Task<TEntity?> FirstOrDefaultAsync(
        Expression<Func<TEntity, bool>> predicate,
        bool withTracking = false,
        params Expression<Func<TEntity, object>>[] lazySelectors);

        public Task<List<TEntity>> ListOrDefaultAsync(
            Expression<Func<TEntity, bool>> predicate,
            bool withTracking = false,
            params Expression<Func<TEntity, object>>[] lazySelectors);

        public Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate);

        public Task AddAsync(TEntity entity);
        public void Update(TEntity entity);
        public Task SaveChangesAsync();
    }
}
