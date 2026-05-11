using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WiseEnemy : Enemy
{
    private float jumpForce;
    private float skillCoolDown;
    public WiseEnemy(int health, float moveSpeed, Weapon currenWeapon,bool isDead
     , int damage, float detactionRange, float attackRange,
     float jumpForce, float skillCoolDown) 
     : base(health, moveSpeed, currenWeapon, isDead, damage, detactionRange, attackRange)
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
    public override void detectPlayer()
    {
        
    }
    public override void chasePlayer()
    {
        
    }
    public override void move()
    {
        
    }
    public override void attack()
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
