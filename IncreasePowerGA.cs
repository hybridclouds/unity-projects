using UnityEngine;

public class IncreasePowerGA : GameAction
{
    public Card Card { get; }
    public CardView CardView { get; }
    public int Amount { get; }

    public IncreasePowerGA(Card card, CardView cardView, int amount)
    {
        Card = card;
        CardView = cardView;
        Amount = amount;
    }
}
