using UnityEngine;

public class SpendEnergyGA : GameAction
{
    public int Amount { get; set; }

    public SpendEnergyGA(int amount)
    {
        Amount = amount;
    }
}
