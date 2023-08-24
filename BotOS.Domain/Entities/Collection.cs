using BotOS.Domain.Common;

namespace BotOS.Domain.Entities
{
    public sealed class Collection : IEntityBase
    {
        public int Id { get; set; }
        public string? Slug { get; set; }
        public string? ContractAddress { get; set; }

        public IEnumerable<Nft>? Nfts { get; set; }
        public IEnumerable<Transaction>? Transactions { get; set; }
    }
}
