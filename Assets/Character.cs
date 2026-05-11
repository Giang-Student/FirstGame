using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    private int health;
    private float moveSpeed;
    private Weapon currenWeapon;
    private bool isDead;
    public Character (int health, float moveSpeed,
     Weapon currenWeapon, bool isDead)
    {
        this.health = health;
        this.moveSpeed = moveSpeed;
        this.currenWeapon = currenWeapon;
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
    public void setCurrenWeapon(Weapon currenWeapon)
    {
        this.currenWeapon = currenWeapon;
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
    public Weapon getCurrentWeapon()
    {
        return currenWeapon;
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
    public abstract void move();
    public abstract void attack();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
