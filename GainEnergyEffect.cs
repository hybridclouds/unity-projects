using System.Collections.Generic;
using UnityEngine;

public class GainEnergyEffect : Effect
{
    [SerializeField] private int gainEnergyAmount;
    public override GameAction GetGameAction(List<UnitView> targets, UnitView caster, Card card)
    {
        GainEnergyGA gainEnergyGA = new(gainEnergyAmount);
        return gainEnergyGA;
    }
}
