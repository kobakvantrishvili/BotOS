using BotOS.Application.Models.Enums;

namespace BotOS.Application.Models.Service_Models
{
    public sealed class OfferServiceModel
    {
        public int Id { get; set; }
        public string? OrderHash { get; set; }
        public string? Chain { get; set; }
        public OfferTypeServiceModel Type { get; set; }
        public CriteriaServiceModel? Criteria { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? IsFulfilled { get; set; }
    }

    public sealed class CriteriaServiceModel
    {
        public string? CollectionSlug { get; set; }
        public string? CollectionAddress { get; set; }
        public string? Trait { get; set; }
        public IEnumerable<int>? TokenIds { get; set; }
        public decimal? Price { get; set; }
    }
}
