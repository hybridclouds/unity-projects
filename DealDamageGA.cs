using UnityEngine;
using System.Collections.Generic;

public class DealDamageGA : GameAction, HasACaster
{
    public int Amount { get; set; }
    public UnitView Caster { get; private set; }
    public int TrueDamageTaken { get; set; }
    public List<UnitView> Targets { get; set; }
    public DealDamageGA(int amount, List<UnitView> targets, UnitView caster)
    {
        Amount = amount;
        Targets = new(targets);
        Caster = caster;
    }
}
