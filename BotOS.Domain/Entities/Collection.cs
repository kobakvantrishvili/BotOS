using BotOS.Domain.Common;

namespace BotOS.Domain.Entities
{
    public sealed class Collection : IEntityBase
    {
        public int Id { get; set; }
        public string? Slug { get; set; }
        public string? ContractAddress { get; set; }
        public int BotId { get; set; }

        public IEnumerable<Nft>? Nfts { get; set; }
        public Bot? Bot { get; set; }

    }
}
