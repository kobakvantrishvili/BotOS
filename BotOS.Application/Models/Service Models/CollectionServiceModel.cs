namespace BotOS.Application.Models.Service_Models
{
    public sealed class CollectionServiceModel
    {
        public int Id { get; set; }
        public string? Slug { get; set; }
        public string? ContractAddress { get; set; }
        public int BotId { get; set; }

        public List<NftServiceModel>? Nfts { get; set; }
        public BotServiceModel? Bot { get; set; }
    }
}
