namespace BotOS.Application.Models.Service_Models
{
    public sealed class TransactionServiceModel
    {
        public int Id { get; set; }
        public string? BlockNumber { get; set; }
        public string? TimeStamp { get; set; }
        public string? Hash { get; set; }
        public string? Nonce { get; set; }
        public string? BlockHash { get; set; }
        public string? From { get; set; }
        public string? To { get; set; }
        public int TokenId { get; set; }
        public string? TokenValue { get; set; }
        public string? TokenName { get; set; }
        public string? TokenSymbol { get; set; }
        public string? TokenDecimal { get; set; }
        public string? Index { get; set; }
        public long? Gas { get; set; }
        public long? GasPrice { get; set; }
        public long? GasUsed { get; set; }
        public long? CumulativeGasUsed { get; set; }
        public string? Input { get; set; }
        public string? Confirmations { get; set; }
    }
}
