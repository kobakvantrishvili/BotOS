namespace BotOS.Application.Models.Service_Models
{
    public sealed class NftServiceModel
    {
        public int Id { get; set; }
        public int TokenId { get; set; }
        public string? Name { get; set; }
        public List<TraitServiceModel>? Traits { get; set; }
        public RarityServiceModel? Rarity { get; set; }
        public bool? IsDisabled { get; set; }
        public bool? IsSuspicious { get; set; }
        public int CollectionId { get; set; }

        public CollectionServiceModel? Collection { get; set; }
    }

    public sealed class TraitServiceModel
    {
        public string? TraitType { get; set; }
        public string? DisplayType { get; set; }
        public string? MaxValue { get; set; }
        public int TraitCount { get; set; }
        public string? Order { get; set; }
        public string? Value { get; set; }
    }

    public sealed class RarityServiceModel
    {
        public string? StrategyId { get; set; }
        public string? StrategyVersion { get; set; }
        public int? Rank { get; set; }
        public double? Score { get; set; }
        public DateTime? CalculatedAt { get; set; }
        public int MaxRank { get; set; }
    }
}
