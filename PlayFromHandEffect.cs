using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayFromHandEffect : Effect
{
    public override GameAction GetGameAction(List<UnitView> targets, UnitView caster, Card card)
    {
        return null;
    }
}
