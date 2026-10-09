using UnityEngine;

public class SelectCardForPowerGA : GameAction
{
    public int Amount { get; }

    public SelectCardForPowerGA(int amount)
    {
        Amount = amount;
    }
}
