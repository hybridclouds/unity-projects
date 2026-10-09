using UnityEngine;

public class ApplyBurnGA : GameAction
{
    public UnitView Target { get; private set; }
    
    public ApplyBurnGA (UnitView target)
    {
        Target = target;
    }
}
