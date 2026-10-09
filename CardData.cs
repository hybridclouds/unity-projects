using UnityEngine;
using System.Collections.Generic;
using SerializeReferenceEditor;

[CreateAssetMenu(menuName = "Data/Card")]

public class CardData : ScriptableObject
{
    [field: SerializeField] public CardType Type { get; private set; }
    [field: SerializeField] public CardAttribute Attribute { get; private set; }
    [field: SerializeField] public int Power { get; private set; }
    [field: SerializeField] public int EnergyCost { get; private set; }
    [field: SerializeField] public string Description { get; private set; }
    [field: SerializeField] public Sprite Image { get; private set; }
    [field: SerializeReference, SR] public Effect ManualTargetEffect { get; private set; } = null;
    [field: SerializeReference, SR] public List<AutoTarget> OtherEffects { get; private set; }
}
