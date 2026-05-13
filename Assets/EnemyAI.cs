using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private float detactionRange;
    private float attackRange;
    public EnemyAI(float detactionRange, float attackRange)
    {
        this.detactionRange = detactionRange;
        this.attackRange = attackRange;
    }
    public void setDetactionRange(float detactionRange)
    {
        this.detactionRange = detactionRange;
    }
    public void setAttackRange(float attackRange)
    {
        this.attackRange = attackRange;
    }
    public float getDetactionRange()
    {
        return detactionRange;
    }
    public float getAttackRange()
    {
        return attackRange;
    }
    public void detectPlayer()
    {
        
    }
    public void chasePlayer()
    {
        
    }
    public void decideAction()
    {
        
    }
    // Start is called before the first frame update

}
