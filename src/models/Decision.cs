namespace Attesture.AE.models
{
    public record Decision : SarmResource
    {
        public required string ScopeItemId { get; init; }
        public required string DecisionValue { get; init; }
        public required string CertifierId { get; init; }
        public required DateTimeOffset DecidedAt { get; init; }
        public string? Channel { get; init; }
        public string? Comment { get; init; }
        public string? DelegatedFrom { get; init; }
    }
}