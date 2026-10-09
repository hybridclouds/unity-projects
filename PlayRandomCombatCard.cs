using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayRandomCombatCard : Effect
{
    public override GameAction GetGameAction(List<UnitView> targets, UnitView caster, Card card)
    {
        card = CardSystem.Instance.GetRandomCombatCard();
        if (card == null)
        {
            return null;
        }
        if (targets == null || targets.Count == 0)
        {
            return null;
        }

        EnemyView target = targets[0] as EnemyView;

        if (target == null)
        {
            return null;
        }

        return new PlayCardGA(card, target, AttackType.COMBO);
    }
}
