using System.Collections.Generic;
using UnityEngine;

public class AddStatusEffectEffect : Effect
{
    [SerializeField] private StatusEffectType statusEffectType;
    [SerializeField] private int stackCount;
    public override GameAction GetGameAction(List<UnitView> targets, UnitView caster, Card card)
    {
        return new AddStatusEffectGA(statusEffectType, stackCount, targets);
    }
}
