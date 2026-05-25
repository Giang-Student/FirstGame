using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 15f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;

    [Header("Input Settings")]
    public InputAction moveAction;
    public InputAction jumpAction;


    private Animator animator;
    private bool isGrounded;
    private Rigidbody2D rb;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        moveAction.Enable();
        jumpAction.Enable();
    }

    private void OnDisable()
    {
        moveAction.Disable();
        jumpAction.Disable();
    }

    void Update()
    {
        HandleMovement();
        HandleJump();
        UpdateAnimation();
    }

    private void HandleMovement()
{
    float moveInput = moveAction.ReadValue<float>();

    rb.linearVelocity = new Vector2(
        moveInput * moveSpeed,
        rb.linearVelocity.y
    );

    // Lấy Scale hiện tại của nhân vật
    Vector3 currentScale = transform.localScale;

    // Lật mặt dựa trên hướng di chuyển (giữ nguyên tỷ lệ gốc)
    if (moveInput > 0)
    {
        currentScale.x = Mathf.Abs(currentScale.x);
    }
    else if (moveInput < 0)
    {
        currentScale.x = -Mathf.Abs(currentScale.x);
    }

    // Áp dụng lại Scale mới
    transform.localScale = currentScale;
}
    private void HandleJump()
    {
        isGrounded = Physics2D.OverlapCircle(
            groundCheck.position,
            0.2f,
            groundLayer
        );

        if (jumpAction.WasPressedThisFrame() && isGrounded)
        {
            rb.linearVelocity = new Vector2(
                rb.linearVelocity.x,
                jumpForce
            );
        }
    }
    private void UpdateAnimation()
    {
        bool Running = Mathf.Abs(rb.linearVelocity.x) > 0.1f;
        bool Jumping = !isGrounded;
        animator.SetBool("Running", Running);
        animator.SetBool("Jumping", Jumping);
    }
}