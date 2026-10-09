using UnityEngine;

public class GainEnergyGA : GameAction
{
    public int Amount { get; set; }

    public GainEnergyGA(int amount)
    {
        Amount = amount;
    }
}
