namespace Savitar.Domain.Models.Dtos
{
    public record EthInfo
    {
        public decimal LatestBlockNumber { get; set; }
        public decimal Balance { get; set; }
        public string NetworkVersion { get; set; }
    }
}
