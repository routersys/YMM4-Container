using System.Collections.ObjectModel;
using YukkuriMovieMaker.Plugin;

namespace Container;

public class EffectTabSettings : SettingsBase<EffectTabSettings>
{
    public override SettingsCategory Category => SettingsCategory.None;

    public override string Name => string.Empty;

    public override bool HasSettingView => false;

    public override object? SettingView => null;

    public ObservableCollection<EffectTab> Stashes { get; } = [];

    public ObservableCollection<EffectTab> Bookmarks { get; } = [];

    public override void Initialize()
    {

    }
}