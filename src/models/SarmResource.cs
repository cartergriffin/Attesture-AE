namespace Attesture.AE.models
{
    public abstract record SarmResource
    {
        public required List<string> Schemas { get; init; }
        public required string Id { get; init; }
        public required Meta Meta { get; init; }
    }
}