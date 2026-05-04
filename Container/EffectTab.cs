namespace Container;

public sealed class EffectTab
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public string SerializedEffects { get; set; } = string.Empty;
}
