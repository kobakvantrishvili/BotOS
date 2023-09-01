using BotOS.Domain.Common;

namespace BotOS.Domain.Entities
{
    public sealed class Nft : IEntityBase
    {
        public int Id { get; set; }
        public int TokenId { get; set; }
        public string? Name { get; set; }
        public IEnumerable<Trait>? Traits { get; set; }
        public Rarity? Rarity { get; set; }
        public bool? IsDisabled { get; set; }
        public bool? IsSuspicious { get; set; }
        public int CollectionId { get; set; }

        public Collection? Collection { get; set; }

    }

    public sealed class Trait
    {
        public string? TraitType { get; set; }
        public string? DisplayType { get; set; }
        public string? MaxValue { get; set; }
        public int TraitCount { get; set; }
        public string? Order { get; set; }
        public string? Value { get; set; }
    }

    public sealed class Rarity
    {
        public string? StrategyId { get; set; }
        public string? StrategyVersion { get; set; }
        public int? Rank { get; set; }
        public double? Score { get; set; }
        public DateTime? CalculatedAt { get; set; }
        public int MaxRank { get; set; }
    }
}
