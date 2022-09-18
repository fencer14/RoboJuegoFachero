using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horizontal;
    public float walkVel = 3f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        if(horizontal < 0.0f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (horizontal > 0.0f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * walkVel, rb.velocity.y);    
    }
}
