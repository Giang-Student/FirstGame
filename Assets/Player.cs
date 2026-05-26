using UnityEngine;

public class Player : Character
{
    [Header("Movement")]
    [SerializeField] private float jumpForce;

    [Header("Ground Check")]
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;

    [Header("Aim")]
    [SerializeField] private Aim aim;

    private bool isGrounded;

    private Animator animator;
    private Rigidbody2D rb;

    // public Player(
    //     int health,
    //     float moveSpeed,
    //     bool isDead,
    //     float jumpForce
    // ) : base(health, moveSpeed, isDead)
    // {
    //     this.jumpForce = jumpForce;
    // }

    public void setJumpForce(float jumpForce)
    {
        this.jumpForce = jumpForce;
    }

    public void setGroundLayer(LayerMask groundLayer)
    {
        this.groundLayer = groundLayer;
    }

    public void setGroundCheck(Transform groundCheck)
    {
        this.groundCheck = groundCheck;
    }

    public void setAim(Aim aim)
    {
        this.aim = aim;
    }

    public void setIsGrounded(bool isGrounded)
    {
        this.isGrounded = isGrounded;
    }

    public void setAnimator(Animator animator)
    {
        this.animator = animator;
    }

    public void setRb(Rigidbody2D rb)
    {
        this.rb = rb;
    }

    public float getJumpForce()
    {
        return jumpForce;
    }

    public LayerMask getGroundLayer()
    {
        return groundLayer;
    }

    public Transform getGroundCheck()
    {
        return groundCheck;
    }

    public Aim getAim()
    {
        return aim;
    }

    public bool getIsGrounded()
    {
        return isGrounded;
    }

    public Animator getAnimator()
    {
        return animator;
    }

    public Rigidbody2D getRb()
    {
        return rb;
    }

    private void Move()
    {
        float direction = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(
            direction * getMoveSpeed(),
            rb.velocity.y
        );

        Flip(direction);
    }

    private void Flip(float direction)
    {
        if(!getIsDead())
        {
            Vector3 scale = transform.localScale;

            if (direction > 0)
            {
                scale.x = Mathf.Abs(scale.x);
            }
            else if (direction < 0)
            {
                scale.x = -Mathf.Abs(scale.x);
            }

            transform.localScale = scale;
        }
    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(
                rb.velocity.x,
                jumpForce
            );
        }

        if(getIsDead())
        {
            setJumpForce(0);
        }
    }

    private void GroundCheck()
    {
        isGrounded = Physics2D.OverlapCircle(
            groundCheck.position,
            0.2f,
            groundLayer
        );
    }

    private void UpdateAnimation()
    {
        bool Running =
            Mathf.Abs(rb.velocity.x) > 0.1f;

        bool Jumping = !isGrounded;
        bool Die = getIsDead();

        animator.SetBool("Die", Die);
        animator.SetBool("Running", Running);

        animator.SetBool("Jumping", Jumping);
    }

    public override Vector3 getAimTarget()
    {
        return aim.getMousePosition();
    }

    public override bool getFireCondition()
    {
        if(Input.GetButton("Fire1"))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GroundCheck();

        Move();

        Jump();

        UpdateAnimation();
    }

    private void OnDrawGizmosSelected()
    {
        if (groundCheck == null)
            return;

        Gizmos.color = Color.green;

        Gizmos.DrawWireSphere(
            groundCheck.position,
            0.2f
        );
    }
}