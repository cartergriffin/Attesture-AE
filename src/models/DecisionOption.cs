namespace Attesture.AE.models
{
    // purely POC, this is likely to be defined by the SS and any logic should
    // respect what they send so long as they send something
    public record DecisionOption
    {
        public required string Value { get; init; }
        public required string Label { get; init; }
    }
}