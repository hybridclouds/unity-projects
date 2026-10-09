using UnityEngine;

public class DefeatEnemyGA : GameAction
{
    public EnemyView EnemyView {  get; private set; }
    public DefeatEnemyGA(EnemyView enemyView)
    {
        EnemyView = enemyView;
    }
}
