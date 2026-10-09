using System.Collections.Generic;
using UnityEngine;

public class HealGA : GameAction, HasACaster
{
    public int Amount { get; set; }
    public UnitView Caster { get; private set; }
    public List<UnitView> Targets { get; set; }
    public HealGA(int amount, List<UnitView> targets, UnitView caster)
    {
        Amount = amount;
        Targets = new(targets);
        Caster = caster;
    }
}
