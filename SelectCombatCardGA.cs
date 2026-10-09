using UnityEngine;

public class SelectCombatCardGA : GameAction
{
    public EnemyView Target { get; }
    public bool HasTarget => Target != null;

    public SelectCombatCardGA()
    {
        Target = null;
    }
    public SelectCombatCardGA(EnemyView target)
    {
        Target = target;
    }
}
