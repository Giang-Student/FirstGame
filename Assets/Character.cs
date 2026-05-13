using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private int health;
    private float moveSpeed;
    private bool isDead;
    public Character (int health, float moveSpeed, bool isDead)
    {
        this.health = health;
        this.moveSpeed = moveSpeed;
        this.isDead = isDead;
    }
    public void setHealth(int health)
    {
        this.health= health;
    }
    public void setMoveSpeed(float moveSpeed)
    {
        this.moveSpeed = moveSpeed;
    }
    public void setIsDead(bool isDead)
    {
        this.isDead = isDead;
    }
    public int getHealth()
    {
        return health;
    }
    public float getMoveSpeed()
    {
        return moveSpeed;
    }
    public bool getIsDead()
    {
        return isDead;
    }
    public void takeDamage(int damage)
    {
        
    }
    public void die()
    {
        
    }
}
