using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody2D rb;
    Animator ani;

    public float speed = 5.5f;
    float xVelocity;
    float yVelocity;

    private float playerCurrSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

   
    void Update()
    {
        playerMovement();

        playerCurrSpeed = rb.velocity.magnitude;
        ani.SetFloat("Speed", playerCurrSpeed);
    }

    /*
     * function playerMovement
     * Player controller moving logic
     */
    void playerMovement()
    {
        xVelocity  = Input.GetAxisRaw("Horizontal");
        yVelocity = Input.GetAxisRaw("Vertical");

        Vector2 dir = new Vector2(xVelocity, yVelocity).normalized;
        rb.velocity = dir * speed;

        /*
         * character direction horizontal turning logic 
         */
        if(xVelocity != 0)
        {
            transform.localScale = new Vector3(xVelocity, transform.localScale.y, transform.localScale.z);
        }
    }
}
