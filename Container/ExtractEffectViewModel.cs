using System.Collections.Immutable;
using YukkuriMovieMaker.Plugin.Effects;

namespace Container;

public class ExtractEffectViewModel
{
    public string Name { get; }
    public string SerializedEffect { get; }

    public ExtractEffectViewModel(IVideoEffect effect)
    {
        Name = effect.Label;
        SerializedEffect = EffectSerializer.Serialize([effect]);
    }
}
