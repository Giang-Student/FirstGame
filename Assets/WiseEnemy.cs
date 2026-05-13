using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiseEnemy : Enemy
{
    private float jumpForce;
    private float skillCoolDown;
    public WiseEnemy(int health, float moveSpeed,bool isDead
     , int damage,
     float jumpForce, float skillCoolDown) 
     : base(health, moveSpeed, isDead, damage)
    {
        this.jumpForce = jumpForce;
        this.skillCoolDown = skillCoolDown;
    }
    public void setJumpForce(float jumpForce)
    {
        this.jumpForce = jumpForce;
    }
    public void setSkillCoolDown(float skillCoolDown)
    {
        this.skillCoolDown = skillCoolDown;
    }
    public float getJumpForce()
    {
        return jumpForce;
    }
    public float getSkillCoolDown()
    {
        return skillCoolDown;
    }
    public void jump()
    {
        
    }
    public void dodge()
    {
        
    }
    public void specialAttack()
    {
        
    }
}
