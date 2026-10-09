using UnityEngine;

public class EnemyAttackGA : GameAction, HasACaster
{
    public EnemyView Attacker { get; private set; }
    public UnitView Caster {  get; private set; }
    public EnemyAttackGA(EnemyView attacker)
    {
        Attacker = attacker;
        Caster = Attacker;
    }
}
