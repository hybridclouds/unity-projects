using UnityEngine;

public class CreateTokenGA : GameAction
{
    public CardData CardData { get; }
    public int TokenAmount { get; }

    public CreateTokenGA(CardData cardData, int tokenAmount)
    {
        CardData = cardData;
        TokenAmount = tokenAmount;
    }
}
