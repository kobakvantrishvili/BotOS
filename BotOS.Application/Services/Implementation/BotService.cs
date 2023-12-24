using BotOS.Application.Models.Service_Models;
using BotOS.Application.Services.Abstraction;
using BotOS.Domain.Entities;
using System.Linq.Expressions;

namespace BotOS.Application.Services.Implementation
{
    public sealed class BotService : IBotService
    {
        public Task<int> CreateBotAsync(BotServiceModel botServiceModel)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBotAsync(Expression<Func<Bot, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<BotServiceModel> GetBotAsync(Expression<Func<Bot, bool>> predicate, bool withTracking = false, params Expression<Func<Bot, object>>[] lazySelectors)
        {
            throw new NotImplementedException();
        }

        public Task<List<BotServiceModel>> GetBotListAsync(Expression<Func<Bot, bool>> predicate, bool withTracking = false, params Expression<Func<Bot, object>>[] lazySelectors)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBotAsync(BotServiceModel botServiceModel)
        {
            throw new NotImplementedException();
        }
    }
}
