using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    private int damage;
    public Enemy(int health, float moveSpeed,
     bool isDead, int damage) 
     : base(health, moveSpeed, isDead)
    {
        this.damage = damage;
    }
    public void setDamage(int damage)
    {
        this.damage = damage;
    }
    public int getDamage()
    {
        return damage;
    }
}
