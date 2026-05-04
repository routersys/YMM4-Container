namespace Container;

internal sealed record MoveTabToIndexParameter(
    EffectTabItemViewModel Tab,
    int TargetIndex);
