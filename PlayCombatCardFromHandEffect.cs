using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayCombatCardFromHandEffect : Effect
{
    public override GameAction GetGameAction(List<UnitView> targets, UnitView caster, Card card)
    {
        if (targets == null || targets.Count == 0)
        {
            return null;
        }

        EnemyView target = targets[0] as EnemyView;

        if (target == null)
        {
            return null;
        }

        return new SelectCombatCardGA(target);
    }
}
