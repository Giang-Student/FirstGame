using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{  
    private float speed;
    private int damage;
    private Vector2 direction;
    public Bullet(float speed, int damage, Vector2 direction)
    {
        this.speed = speed;
        this.damage = damage;
        this.direction = direction;
    }
    public void setSpeed(float speed)
    {
        this.speed = speed;
    }
    public void setDamage(int damage)
    {
        this.damage = damage;
    }
    public void setDirection(Vector2 direction)
    {
        this.direction = direction;
    }
    public float getSpeed()
    {
        return speed;
    }
    public int getDamage()
    {
        return damage;
    }
    public Vector2 getDirection()
    {
        return direction;
    }
    public void move()
    {
        
    }
    public void onHit()
    {
        
    }
}
