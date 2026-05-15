using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Bullet : MonoBehaviour
{  
    [SerializeField] private float speed;
    [SerializeField] private int damage;
    private Vector2 direction= Vector2.right;
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
        transform.Translate(direction * speed * Time.deltaTime);
    }
    public void onHit(Collider2D other)
    {
        IDamageable target = other.GetComponent<IDamageable>();

        if (target != null)
        {
            target.TakeDamage(damage);
        }

        Destroy(gameObject);
    }
}
