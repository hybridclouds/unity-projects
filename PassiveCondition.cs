using UnityEngine;
using System;

public abstract class PassiveCondition
{
    protected ReactionTiming reactionTiming;

    public abstract void SubscribeCondition(Action<GameAction> reaction);
    public abstract void UnsubscribeCondition(Action<GameAction> reaction);

    public abstract bool SubConditionIsMet(GameAction gameAction);
}
