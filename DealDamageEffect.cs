using UnityEngine;
using System.Collections.Generic;

public class DealDamageEffect : Effect
{
    [SerializeField] private int damageAmount;
    public override GameAction GetGameAction(List<UnitView> targets, UnitView caster, Card card)
    {
        int amount = card != null ? card.Power : damageAmount;
        return new DealDamageGA(amount, targets, caster);
    }
}
