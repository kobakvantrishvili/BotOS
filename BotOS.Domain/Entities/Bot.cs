using BotOS.Domain.Common;

namespace BotOS.Domain.Entities
{
    public sealed class Bot : IEntityBase
    {
        public int Id { get; set; }
        public decimal? PortfolioValue { get; set; }
        public string? Address { get; set; }
        public IEnumerable<Token>? Tokens { get; set; }
        public IEnumerable<Collection>? Collections { get; set; }
    }

    public sealed class Token
    {
        public string? Chain { get; set; }
        public string? Address { get; set; }
        public string? Symbol { get; set; }
        public int? Decimals { get; set; } 
        public long? Balance { get; set; }
    }
}
