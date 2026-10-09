using UnityEngine;
using System.Collections.Generic;

public class DrawCardsEffect : Effect
{
    [SerializeField] private int drawAmount;

    public override GameAction GetGameAction(List<UnitView> targets, UnitView caster, Card card)
    {
        DrawCardsGA drawCardsGA = new(drawAmount);
        return drawCardsGA;        
    }
}
