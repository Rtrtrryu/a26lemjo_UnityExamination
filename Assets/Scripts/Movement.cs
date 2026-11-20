using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Movement Settings")]
    [Tooltip("Movement speed in units per second.")]
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private float moveInput;

    void Awake()
    {
        // Get and validate Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody2D component missing! Please add one to the GameObject.");
        }
    }

    void Update()
    {
        // Get horizontal input from A/D or Left/Right arrow keys
        moveInput = Input.GetAxisRaw("Horizontal"); // -1 for left, 1 for right, 0 for no input
    }

    void FixedUpdate()
    {
        // Apply movement only if Rigidbody2D exists
        if (rb != null)
        {
            rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
        }
    }
}