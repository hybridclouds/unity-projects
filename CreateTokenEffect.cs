using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CreateTokenEffect : Effect
{
    [SerializeField] private CardData cardData;
    [SerializeField] private int tokenAmount = 1;
    public override GameAction GetGameAction(List<UnitView> targets, UnitView caster, Card card)
    {
        return new CreateTokenGA(cardData, tokenAmount);
    }
}
