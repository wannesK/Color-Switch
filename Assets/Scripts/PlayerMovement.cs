using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce = 10f;

    private Rigidbody2D rigidbody2d;
    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        PlayerJump();
    }
    private void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rigidbody2d.velocity = Vector2.up * jumpForce;
        }
    }
}
