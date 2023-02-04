using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    Rigidbody2D rb;

    public float speed = 5.5f;
    float xVelocity;
    float yVelocity;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        playerMovement();
    }

    /*
     * function playerMovement
     * Player controller moving logic
     */
    void playerMovement()
    {
        xVelocity  = Input.GetAxisRaw("Horizontal");
        yVelocity = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(xVelocity * speed, yVelocity * speed);

        /*
         * character direction horizontal turning logic 
         */
        if(xVelocity != 0)
        {
            transform.localScale = new Vector3(xVelocity, 1, 1);
        }
    }
}
