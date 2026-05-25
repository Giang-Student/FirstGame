
using UnityEngine;

public class NormalEnemy : Enemy
{
    [SerializeField] private float patroDistance; //khoảng cách tuần tra
    // public NormalEnemy(int health, float moveSpeed, bool isDead
    //  , /*int damage,*/
    //  float patroDistance) 
    //  : base(health, moveSpeed, isDead/*, damage*/)
    // {
    //     this.patroDistance = patroDistance;
    // }
    public void setPatroDistance(float patroDistance)
    {
        this.patroDistance = patroDistance;
    }
    public float getPatroDistance()
    {
        return patroDistance;
    }
    public override string getAnimRun()
    {
        return "enemyRun";
    }
    public override string getAnimDie()
    {
        return "enemyDie";
    }
}
