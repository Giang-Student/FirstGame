
using UnityEngine;

public class WiseEnemy : Enemy
{
    [SerializeField] private float jumpForce;
    // [SerializeField] private float skillCoolDown;
    public WiseEnemy(int health, float moveSpeed,bool isDead
     , /*int damage,*/
     float jumpForce/*, float skillCoolDown*/) 
     : base(health, moveSpeed, isDead/*, damage*/)
    {
        this.jumpForce = jumpForce;
        // this.skillCoolDown = skillCoolDown;
    }
    public void setJumpForce(float jumpForce)
    {
        this.jumpForce = jumpForce;
    }
    // public void setSkillCoolDown(float skillCoolDown)
    // {
    //     this.skillCoolDown = skillCoolDown;
    // }
    public float getJumpForce()
    {
        return jumpForce;
    }
    // public float getSkillCoolDown()
    // {
    //     return skillCoolDown;
    // }
    public void jump()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        rb.velocity = new Vector2(rb.velocity.x, getJumpForce());
    }
    // public void dodge()
    // {
    //     {
    //     Rigidbody2D rb = GetComponent<Rigidbody2D>();

    //     rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    // }
    // }
    // public void specialAttack()
    // {
    //     if (enemyCombat != null)
    //     {
    //         enemyCombat.Attack();
    //     }
    // }
}
