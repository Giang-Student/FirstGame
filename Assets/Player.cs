using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Player : Character
{
    private float jumpForce;
    public Player(int health, float moveSpeed,
     bool isDead, float jumpForce) 
     : base(health, moveSpeed, isDead)
    {
        this.jumpForce = jumpForce;
    }
    public void setJumpForce(float jumpForce)
    {
        this.jumpForce = jumpForce;
    }
    public float getJumpForce()
    {
        return jumpForce;
    }
    public void jump()
    {
        
    }
    public void move()
    {
    
    }
}
