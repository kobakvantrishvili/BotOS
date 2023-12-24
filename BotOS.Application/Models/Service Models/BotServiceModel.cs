namespace BotOS.Application.Models.Service_Models
{
    public sealed class BotServiceModel
    {
        public int Id { get; set; }
        public decimal? PortfolioValue { get; set; }
        public string? Address { get; set; }
        public List<TokenServiceModel>? Tokens { get; set; }
        public List<CollectionServiceModel>? Collections { get; set; }
    }

    public sealed class TokenServiceModel
    {
        public string? Chain { get; set; }
        public string? Address { get; set; }
        public string? Symbol { get; set; }
        public int? NumDecimals { get; set; }
        public double? Balance { get; set; }
        public decimal? Value { get; set; }

    }
}
