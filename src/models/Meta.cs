namespace Attesture.AE.models
{
    public record Meta{
        public required string ResourceType { get; init; }
        public required DateTimeOffset Created { get; init; }
        public required DateTimeOffset LastModified { get; init; }
        public string? Version { get; init; }
        public required Uri Location { get; init; }
    }
} 