using UnityEngine;

public class Player : MonoBehaviour
{
    // public Fields
    private float moveSpeed = 5f; 
    private float jumpForce = 10f;

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
}
