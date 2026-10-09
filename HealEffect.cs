using System.Collections.Generic;
using UnityEngine;

public class HealEffect : Effect
{
    [SerializeField] private int healAmount;

    public override GameAction GetGameAction(List<UnitView> targets, UnitView caster, Card card)
    {
        HealGA healGA = new(healAmount, targets, caster);
        return healGA;
    }
}
