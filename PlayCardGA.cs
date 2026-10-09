using UnityEngine;

public class PlayCardGA : GameAction
{
    public Card Card { get; set; }
    public CardView CardView { get; set; }
    public EnemyView ManualTarget { get; set; }
    public AttackType AttackType { get; set; }
    public bool WasActivated { get; set; }
    public PlayCardGA(Card card)
    {
        Card = card;
        ManualTarget = null;
        AttackType = card.AttackType;
        WasActivated = false;
    }
    public PlayCardGA(Card card, EnemyView target)
    {
        Card = card;
        ManualTarget = target;
        AttackType = card.AttackType;
        WasActivated = false;
    }
    public PlayCardGA(Card card, EnemyView target, AttackType attackType)
    {
        Card = card;
        ManualTarget = target;
        AttackType = attackType;
        WasActivated = false;
    }
}
