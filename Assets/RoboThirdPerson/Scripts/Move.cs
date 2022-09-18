using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontal;
    public float walkVel = 3f;
    public float jumpForce;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * walkVel, rb.velocity.y);    }
}
