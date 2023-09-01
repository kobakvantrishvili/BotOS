using BotOS.Domain.Common;
using BotOS.Persistence.Repo.Abstraction;
using Microsoft.EntityFrameworkCore;
using RB.CustomerRiskAssignmentAutomation.Persistence.EF_Core.Repository.Implementation.Extensions;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace BotOS.Persistence.Repo.Implementation
{
    public sealed class Repository<TContext,TEntity> : IRepository<TEntity>
        where TContext : DbContext
        where TEntity : class, IEntityBase
    {
        private readonly TContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(TContext context)
        {
            _dbContext = context;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AnyAsync(predicate);
        }

        public async Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, bool withTracking = false, params Expression<Func<TEntity, object>>[] lazySelectors)
        {
            return await _dbSet
            .WithLazySelectors<TEntity>(lazySelectors)
            .WithTracking<TEntity>(withTracking)
            .FirstOrDefaultAsync(predicate);
        }

        public async Task<List<TEntity>> ListOrDefaultAsync(Expression<Func<TEntity, bool>> predicate, bool withTracking = false, params Expression<Func<TEntity, object>>[] lazySelectors)
        {
            return await _dbSet
            .WithLazySelectors<TEntity>(lazySelectors)
            .WithTracking<TEntity>(withTracking)
            .Where(predicate)
            .ToListAsync();
        }
        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
