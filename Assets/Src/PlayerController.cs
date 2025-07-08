using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 5f;
    [SerializeField] private float jumpForce = 15f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    private bool isPlayerStandOnGround;

    Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
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
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        isPlayerStandOnGround = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
}
