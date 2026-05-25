
using UnityEngine;

public abstract class Enemy : Character
// , ScoreProvider
{
    [SerializeField] protected Transform player;
    [SerializeField] protected EnemyAI enemyAI;
    public override Vector3 getAimTarget()
    {
        return player.position;
    }
    public override bool getFireCondition()
    {
        return enemyAI.getIsAttack();
    }
    public abstract string getAnimRun();
    public abstract string getAnimDie();
}
