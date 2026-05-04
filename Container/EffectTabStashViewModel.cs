namespace Container;

public sealed class EffectTabStashViewModel : EffectTabBaseViewModel
{
    public EffectTabStashViewModel(EffectTab model) : base(model)
    {

    }

    public string Name => Model.Name;
}
