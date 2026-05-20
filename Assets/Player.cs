using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : Character
{
    [SerializeField] float jumpForce;
    private Inventory inventory;
    private PlayerCombat playerCombat;
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
        // Rigidbody2D rb = GetComponent<Rigidbody2D>();

        // rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
    }
    public void move()
    {
        float direction = Input.GetAxis("Horizontal");
        transform.Translate(base.getMoveSpeed()*direction*Time.deltaTime, 0 ,0);
        // float horizontal = Input.GetAxis("Horizontal");
        // TransformBlock.Translate(Vector2.right*horizontal*moveSpeed*TimeOnly.deltaTime);
    }
    private void Update()
    {
        move();

        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     Jump();
        // }
    }
    // private void Awake()
    // {
    //     // inventory = GetComponent<Inventory>();
    //     // playerCombat = GetComponent<PlayerCombat>();
    // }
}
