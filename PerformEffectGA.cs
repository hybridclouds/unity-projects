using UnityEngine;
using System.Collections.Generic;

public class PerformEffectGA : GameAction
{
    public Effect Effect { get; set; }
    public List<UnitView> Targets { get; set; }
    public Card Card { get; set; }
    public PerformEffectGA(Effect effect, List<UnitView> targets, Card card = null)
    {
        Effect = effect;
        Targets = targets == null ? null : new(targets);
        Card = card;
    }
}
