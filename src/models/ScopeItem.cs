namespace Attesture.AE.models
{
    public record ScopeItem: SarmResource {
        public required string SubjectId { get; init; }
        public required string SubjectLabel { get; init; }
        public required string CertifierHint { get; init; }
        public required List<DecisionOption> DecisionOptions { get; init; }
        public string? ResourceId { get; init; }
        public string? ResourceLabel { get; init; }
        public string? DecisionPrompt { get; init; }
        public Object? ContextData { get; init; }
    }
}