using UnityEngine;

public class Player : MonoBehaviour
{
    // public Fields
    [SerializeField] private float moveSpeed = 5f;
    private float jumpForce = 2f;

    [SerializeField] private bool isInvulnerable = false;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // 1. Movement
        float moveInput = Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);

        // 2. Jump
        if (Input.GetKey(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    void SetMoveSpeed(float newSpeed)
    {
        moveSpeed = newSpeed;
        Debug.Log($"moveSpeed is set to {newSpeed}");
    }

    void SetInvulnerability(bool isEnable)
    {
        if (isEnable)
        {
            isInvulnerable = true;
            Debug.Log($"isInvulnerable is set to true");
        }
        else
        {
            isInvulnerable = false;
            Debug.Log($"isInvulnerable is set to false");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
