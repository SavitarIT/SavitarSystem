namespace Savitar.Domain.Dtos
{
    public record EthInfo
    {
        public decimal LatestBlockNumber { get; init; }
        public decimal Balance { get; init; }
        public string NetworkVersion { get; init; }
    }
}
