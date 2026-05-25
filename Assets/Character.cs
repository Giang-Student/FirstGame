
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private float moveSpeed;
    [SerializeField] private bool isDead;
    // public Character (int health, float moveSpeed, bool isDead)
    // {
    //     this.health = health;
    //     this.moveSpeed = moveSpeed;
    //     this.isDead = isDead;
    // }
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
    public virtual void takeDamage(int damage)
    {
        if (isDead)
        {
            return;
        }
        health -= damage;
        if(health <= 0)
        {
            die();
        }
    }
    public void die()
    {
        // Instantiate(deathEffect, transform.position, Quaternion.identity);
        if (health != 0)
        {
            setHealth(0);
            setIsDead(true);
            setMoveSpeed(0);
            
        }
    }
    public abstract Vector3 getAimTarget();
    public abstract bool getFireCondition();
}
