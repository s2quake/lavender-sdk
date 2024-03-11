namespace Lavender;

public sealed class Denomination(DenominationMetadata metadata)
{
    private readonly DenominationMetadata _metadata = metadata;

    public string Description => _metadata.Description;

    public string Name => _metadata.Description;

    public string DisplayName => _metadata.Description;

    public string Symbol => _metadata.Description;

    public bool IsEnabled { get; set; } = true;
}
