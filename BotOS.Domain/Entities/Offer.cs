using BotOS.Domain.Common;
using BotOS.Domain.Enums;

namespace BotOS.Domain.Entities
{
    public sealed class Offer : IEntityBase
    {
        public int Id { get; set; }
        public string? OrderHash { get; set; }
        public string? Chain { get; set; }
        public OfferType Type { get; set; }
        public Criteria? Criteria { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? IsFulfilled { get; set; }
    }

    public sealed class Criteria
    {
        public string? CollectionSlug { get; set; }
        public string? CollectionAddress { get; set; }
        public string? Trait { get; set; }
        public IEnumerable<int>? TokenIds { get; set; }
    }
}
