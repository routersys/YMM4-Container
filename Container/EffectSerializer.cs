using System.Collections.Immutable;
using YukkuriMovieMaker.Json;
using YukkuriMovieMaker.Plugin.Effects;

namespace Container;

internal static class EffectSerializer
{
    public static string Serialize(ImmutableList<IVideoEffect> effects)
    {
        return Json.GetJsonText(effects);
    }

    public static ImmutableList<IVideoEffect> Deserialize(string json)
    {
        if (string.IsNullOrWhiteSpace(json)) return ImmutableList<IVideoEffect>.Empty;
        try
        {
            var list = Json.LoadFromText<List<IVideoEffect>>(json);
            return list == null ? ImmutableList<IVideoEffect>.Empty : list.ToImmutableList();
        }
        catch
        {
            return ImmutableList<IVideoEffect>.Empty;
        }
    }
}
