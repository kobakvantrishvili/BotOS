using BotOS.Application.Models.Service_Models;
using BotOS.Domain.Entities;
using System.Linq.Expressions;

namespace BotOS.Application.Services.Abstraction
{
    public interface IBotService
    {
        Task<BotServiceModel> GetBotAsync(
            Expression<Func<Bot, bool>> predicate,
            bool withTracking = false,
            params Expression<Func<Bot, object>>[] lazySelectors);

        Task<List<BotServiceModel>> GetBotListAsync(
            Expression<Func<Bot, bool>> predicate, bool withTracking = false,
            params Expression<Func<Bot, object>>[] lazySelectors);

        Task DeleteBotAsync(Expression<Func<Bot, bool>> predicate);
        Task<int> CreateBotAsync(BotServiceModel botServiceModel);
        Task UpdateBotAsync(BotServiceModel botServiceModel);
    }
}
