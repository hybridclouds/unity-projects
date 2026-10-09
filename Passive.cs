using UnityEngine;
using System.Collections.Generic;

public class Passive
{
    public Sprite Image => data.Image;

    private readonly PassiveData data;
    private readonly PassiveCondition condition;
    private readonly AutoTarget autoTargetEffect;
    public Passive(PassiveData passiveData)
    {
        data = passiveData;
        condition = data.passiveCondition;
        autoTargetEffect = data.AutoTarget;
    }
    public void OnAdd()
    {
        condition.SubscribeCondition(Reaction);
    }
    public void OnRemove()
    {
        condition.UnsubscribeCondition(Reaction);
    }
    private void Reaction(GameAction gameAction)
    {
        if (!condition.SubConditionIsMet(gameAction))
        {
            return;
        }
        List<UnitView> targets = new();

        if (data.UseActionCasterAsTarget && gameAction is HasACaster hasACaster)
        {
            targets.Add(hasACaster.Caster);
        }

        if (data.UseAutoTarget)
        {
            List<UnitView> autoTargets = autoTargetEffect.TargetMode.GetTargets(TargetSystem.Instance.TargetHistory);

            if (autoTargets != null)
            {
                targets.AddRange(autoTargets);

                if (autoTargets.Count == 1)
                {
                    TargetSystem.Instance.SetSameTarget(autoTargets[0]);
                }
            }
        }

        GameAction passiveEffectAction = autoTargetEffect.Effect.GetGameAction(targets, HeroSystem.Instance.HeroView, null);
        ActionSystem.Instance.AddReaction(passiveEffectAction);
    }
}
