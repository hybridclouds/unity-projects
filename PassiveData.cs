using UnityEngine;
using SerializeReferenceEditor;

[CreateAssetMenu(menuName = "Data/Passive")]
public class PassiveData : ScriptableObject
{
    [field: SerializeField] public Sprite Image { get; private set; }
    [field: SerializeReference, SR] public PassiveCondition passiveCondition { get; private set; }
    [field: SerializeReference, SR] public AutoTarget AutoTarget { get; private set; }
    [field: SerializeField] public bool UseAutoTarget { get; private set; } = true;
    [field: SerializeField] public bool UseActionCasterAsTarget { get; private set; } = false;
}
