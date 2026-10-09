using System.Collections.Generic;
using UnityEngine;

public class IncreasePowerEffect : Effect
{
    [SerializeField] private int powerIncreaseAmount;
    public int PowerIncreaseAmount => powerIncreaseAmount;
    public override GameAction GetGameAction(List<UnitView> targets, UnitView caster, Card card)
    {
        return null;
    }
}
