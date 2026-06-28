namespace Attesture.AE.models
{
    public abstract record Meta(
        string ResourceType,
        DateTimeOffset Created,
        DateTimeOffset LastModified,
        string Version,
        Uri Location
    );
} 