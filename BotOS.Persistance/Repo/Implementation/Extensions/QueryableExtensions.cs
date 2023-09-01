using BotOS.Domain.Common;
using BotOS.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace RB.CustomerRiskAssignmentAutomation.Persistence.EF_Core.Repository.Implementation.Extensions;

public static class QueryableExtensions
{
    public static IQueryable<TEntity> WithLazySelectors<TEntity>(
        this IQueryable<TEntity> query,
        params Expression<Func<TEntity, object>>[] expressions)
        where TEntity : class, IEntityBase
    {
        return expressions.Aggregate(query, (current, expression) => current.Include(expression));
    }

    public static IQueryable<TEntity> WithTracking<TEntity>(
        this IQueryable<TEntity> dbSet, bool withTracking)
        where TEntity : class, IEntityBase
    {
        if (withTracking)
            return dbSet.AsTracking();
        return dbSet.AsNoTracking();
    }

    public static IQueryable<TEntity> WithMultiplePredicates<TEntity>(
        this IQueryable<TEntity> dbSet, params Expression<Func<TEntity, bool>>[] expressions)
        where TEntity : class, IEntityBase
    {
        return expressions.Aggregate(dbSet, (current, expression) => current.Where(expression));
    }

    public static IQueryable<TEntity> WithOrderBy<TEntity>(
        this IQueryable<TEntity> dbSet, Expression<Func<TEntity, object>> expression, Order? order)
        where TEntity : class, IEntityBase
    {
        if (order is null or Order.Desc)
            return dbSet.OrderByDescending(expression);
        else
            return dbSet.OrderBy(expression);
    }
}