using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce = 150;
    public bool isGrounded;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && isGrounded == true || Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            jump();
        }
        Debug.DrawRay(transform.position, Vector2.down * 0.7f);
        if(Physics2D.Raycast(transform.position, Vector2.down, 0.7f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }

    public void jump()
    {
        rb.AddForce(Vector2.up * jumpForce);
    }
}
