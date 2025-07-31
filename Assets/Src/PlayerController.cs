using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5f;
    [SerializeField] private float jumpForce = 15f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    private bool isPlayerStandOnGround;
    private Animator animator;
    private SoundManager _soundManager;

    private Rigidbody2D rb;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        _soundManager = FindAnyObjectByType<SoundManager>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleJump();
        UpdatePlayerAimation();
    }

    private void HandleMovement()
    {
        float inputMove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(inputMove * playerSpeed, rb.velocity.y);

        if (inputMove > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if
            (inputMove < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }

    private void HandleJump()
    {
        if (Input.GetButtonDown("Jump") && isPlayerStandOnGround)
        {
            _soundManager.PlayJumpSound();
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        isPlayerStandOnGround = Physics2D.OverlapCircle(groundCheck.position, 0.3f, groundLayer);
    }

    private void UpdatePlayerAimation()
    {
        bool isWalking = Mathf.Abs(rb.velocity.x) > 0.1f;
        bool isJumping = !isPlayerStandOnGround;
        bool isFalling = rb.velocity.y < -0.1f && !isPlayerStandOnGround;
        animator.SetBool("isWalking", isWalking);
        animator.SetBool("isJumping", isJumping);
        animator.SetBool("isFalling", isFalling);
    }
}
