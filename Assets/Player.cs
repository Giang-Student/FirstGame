using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player : Character
{
    private int score;
    private float jumpForce;
    public Player(int health, float moveSpeed, Weapon currenWeapon,
     bool isDead, int score, float jumpForce) 
     : base(health, moveSpeed, currenWeapon, isDead)
    {
        this.score = score;
        this.jumpForce = jumpForce;
    }
    public void setScore(int score)
    {
        this.score = score;
    }
    public void setJumpForce(float jumpForce)
    {
        this.jumpForce = jumpForce;
    }
    public int getScore()
    {
        return score;
    }
    public float getJumpForce()
    {
        return jumpForce;
    }
    public void jump()
    {
        
    }
    public override void move()
    {
    
    }
    public override void attack()
    {
        
    }
    public void shoot()
    {
        
    }
    public void meleeAttack()
    {
        
    }
    public void collectionItem(Item item)
    {
        
    }
    public void addScore(int points)
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
