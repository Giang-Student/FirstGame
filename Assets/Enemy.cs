using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    private int damage;
    private float detactionRange;
    private float attackRange;
    public Enemy(int health, float moveSpeed, Weapon currenWeapon,
     bool isDead, int damage, float detactionRange, float attackRange) 
     : base(health, moveSpeed, currenWeapon, isDead)
    {
        this.damage = damage;
        this.detactionRange = detactionRange;
        this.attackRange = attackRange;
    }
    public void setDamage(int damage)
    {
        this.damage = damage;
    }
    public void setDetactionRange(float detactionRange)
    {
        this.detactionRange = detactionRange;
    }
    public void setAttackRange(float attackRange)
    {
        this.attackRange = attackRange;
    }
    public int getDamage()
    {
        return damage;
    }
    public float getDetactionRange()
    {
        return detactionRange;
    }
    public float getAttackRange()
    {
        return attackRange;
    }
    public abstract void detectPlayer();
    public abstract void chasePlayer();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
