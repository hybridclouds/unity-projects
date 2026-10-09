using UnityEngine;
using SerializeReferenceEditor;

[System.Serializable]
public class AutoTarget
{
    [field: SerializeReference, SR] public TargetMode TargetMode {  get; private set; }
    [field: SerializeReference, SR] public Effect Effect { get; private set; }
}
