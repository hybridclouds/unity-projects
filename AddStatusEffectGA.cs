using UnityEngine;
using System.Collections.Generic;

public class AddStatusEffectGA : GameAction
{
    public StatusEffectType StatusEffectType {  get; private set; }
    public int StackCount { get; private set; }
    public List<UnitView> Targets { get; private set; }

    public AddStatusEffectGA(StatusEffectType statusEffectType, int stackCount, List<UnitView> targets)
    {
        StatusEffectType = statusEffectType;
        StackCount = stackCount;
        Targets = targets;
    }
}
