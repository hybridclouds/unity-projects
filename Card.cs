using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System;

public class Card
{
    public CardType Type => data.Type;
    public CardAttribute Attribute => data.Attribute;
    public int OriginalPower => data.Power;
    public int Power { get; private set; }
    public string Title => data.name;
    public string Description => data.Description;
    public int EnergyCost => data.EnergyCost;
    public bool HasPlayFromHandEffect {  get; }
    public bool IsToken {  get; }
    public Sprite Image => data.Image;
    public Effect ManualTargetEffect => data.ManualTargetEffect;
    public List<AutoTarget> OtherEffects => data.OtherEffects;

    public AttackType AttackType { get; set; } = AttackType.BASIC;

    public int PowerIncrease { get; }
    public event Action<int> PowerChanged;

    private readonly CardData data;
    
    public Card(CardData cardData, bool isToken = false)
    {
        data = cardData;
        IsToken = isToken;
        Power = data.Power;

        HasPlayFromHandEffect = ManualTargetEffect is PlayFromHandEffect ||
            (OtherEffects != null && OtherEffects.Any(e => e.Effect is PlayFromHandEffect));

        PowerIncrease = GetPowerIncrease();
    }
    private int GetPowerIncrease()
    {
        int amount = 0;

        if (ManualTargetEffect is IncreasePowerEffect manualEffect)
        {
            amount += manualEffect.PowerIncreaseAmount;
        }
        if (OtherEffects != null)
        {
            foreach (AutoTarget effectWrapper in OtherEffects)
            {
                if (effectWrapper.Effect is IncreasePowerEffect increasePowerEffect)
                {
                    amount += increasePowerEffect.PowerIncreaseAmount;
                }
            }
        }

        return amount;
    }
    public void IncreasePower(int amount)
    {
        Power += amount;
        PowerChanged?.Invoke(Power);
    }
    public void ResetPower()
    {
        if (Power == OriginalPower)
        {
            return;
        }
        Power = OriginalPower;
        PowerChanged?.Invoke(Power);
    }
}
