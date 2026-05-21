using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : Character
{
    [SerializeField] private float jumpForce;
    // [SerializeField] private Inventory inventory;
    // [SerializeField] private PlayerCombat playerCombat;
    private Rigidbody2D rb;

    public Player(int health, float moveSpeed,
     bool isDead, float jumpForce) 
     : base(health, moveSpeed, isDead)
    {
        // this.jumpForce = jumpForce;
    }
    // public void setJumpForce(float jumpForce)
    // {
    //     this.jumpForce = jumpForce;
    // }
    // public float getJumpForce()
    // {
    //     return jumpForce;
    // }
    public void jump()
    {
        if (Input.GetButton("Jump"))
        {
        rb.velocity = new Vector2(rb.velocity.x,jumpForce);
        }
    }
    public void move()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(base.getMoveSpeed()*direction*Time.deltaTime, 0 ,0);
        // float horizontal = Input.GetAxis("Horizontal");
        // TransformBlock.Translate(Vector2.right*horizontal*moveSpeed*TimeOnly.deltaTime);
    }
    private void Awake()
    {
        // inventory = GetComponent<Inventory>();
        // playerCombat = GetComponent<PlayerCombat>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        move();
        jump();
    }
    // private void Awake()
    // {
    //     // inventory = GetComponent<Inventory>();
    //     // playerCombat = GetComponent<PlayerCombat>();
    // }
}
