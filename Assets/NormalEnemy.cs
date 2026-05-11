using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalEnemy : Enemy
{
    private float patroDistance;
    public NormalEnemy(int health, float moveSpeed, Weapon currenWeapon,bool isDead
     , int damage, float detactionRange, float attackRange,
     float patroDistance) 
     : base(health, moveSpeed, currenWeapon, isDead, damage, detactionRange, attackRange)
    {
        this.patroDistance = patroDistance;
    }
    public void setPatroDistance(float patroDistance)
    {
        this.patroDistance = patroDistance;
    }
    public float getPatroDistance()
    {
        return patroDistance;
    }
    public void patrol ()
    {
        
    }
    public override void detectPlayer()
    {
        
    }
    public override void chasePlayer()
    {
        
    }
    public override void move()
    {
        
    }
    public override void attack()
     {
        
     }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
